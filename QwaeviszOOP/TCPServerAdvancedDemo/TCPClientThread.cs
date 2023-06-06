using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace TCPServerAdvancedDemo
{
    public class TCPClientThread
    {

        private TcpClient client;
        private ClientKillCallback callback;

        public TCPClientThread( TcpClient client, ClientKillCallback callback )
        {
            this.client = client;
            this.callback = callback;
        }

        public void Run()
        {
            NetworkStream networkStream = client.GetStream();
            while (true)
            {
                string command = this.ReadTextFromClient(client, networkStream);
                Console.WriteLine("Received command: " + command);
                this.WriteTextToClient(networkStream, "OK");

                if (command.Equals("exit"))
                {
                    Console.WriteLine("Exit...");
                    break;
                } else if (command.Equals("kill"))
                {
                    if (this.callback != null)
                    {
                        this.callback.Invoke();
                    }
                    break;
                }
                else
                {
                    switch (command)
                    {
                        case "talk":
                            this.WriteTextToClient(networkStream, "What's your name?");
                            string name = this.ReadTextFromClient(client, networkStream);
                            this.WriteTextToClient(networkStream, "How old are you?");
                            int age = Int32.Parse(this.ReadTextFromClient(client, networkStream));
                            if (age > 18)
                            {
                                this.WriteTextToClient(networkStream, "Dear " + name + ". Welcome!");
                            }
                            else
                            {
                                this.WriteTextToClient(networkStream, "Hello " + name + ". Visit Disneyland");
                            }
                            break;
                        case "add":
                            int a = Int32.Parse(this.ReadTextFromClient(client, networkStream));
                            int b = Int32.Parse(this.ReadTextFromClient(client, networkStream));
                            this.WriteTextToClient(networkStream, "" + (a + b));
                            break;
                    }
                }
            }
            client.Close();
        }

        private string ReadTextFromClient(TcpClient client, NetworkStream networkStream)
        {

            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead = networkStream.Read(buffer, 0, client.ReceiveBufferSize);
            return Encoding.ASCII.GetString(buffer, 0, bytesRead);
        }

        private void WriteTextToClient(NetworkStream networkStream, string text)
        {
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(text);
            networkStream.Write(bytesToSend, 0, bytesToSend.Length);
        }

    }
}
