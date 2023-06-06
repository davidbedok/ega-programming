using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace TCPClientDemo
{
    public class TCPClientApplication
    {

        private TcpClient client;

        public TCPClientApplication()
        {
            this.client = new TcpClient();
        }

        public void Connect( string host, int port)
        {
            this.client.Connect(host, port);
            NetworkStream networkStream = client.GetStream();

            while ( true )
            {
                Console.Write("Command: ");
                string command = Console.ReadLine();
                this.WriteTextToServer(networkStream, command);

                string ackMessage = this.ReadTextFromServer(client, networkStream);
                if (ackMessage.Equals("OK"))
                {
                    if (command.Equals("exit") || command.Equals("kill"))
                    {
                        break;
                    }
                    else
                    {
                        switch (command)
                        {
                            case "talk":
                                Console.Write(this.ReadTextFromServer(client, networkStream));
                                this.WriteTextToServer(networkStream, Console.ReadLine());
                                Console.Write(this.ReadTextFromServer(client, networkStream));
                                this.WriteTextToServer(networkStream, Console.ReadLine());
                                Console.WriteLine(this.ReadTextFromServer(client, networkStream));
                                break;
                            case "add":
                                Console.Write("A: ");
                                this.WriteTextToServer(networkStream, Console.ReadLine());
                                Console.Write("B: ");
                                this.WriteTextToServer(networkStream, Console.ReadLine());
                                string result = this.ReadTextFromServer(client, networkStream);
                                Console.WriteLine("A + B = " + result);
                                break;
                        }
                    }
                }
            }
            this.client.Close();
        }

        private void WriteTextToServer(NetworkStream networkStream, String text)
        {
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(text);
            networkStream.Write(bytesToSend, 0, bytesToSend.Length);
        }
        private string ReadTextFromServer(TcpClient client, NetworkStream networkStream)
        {

            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead = networkStream.Read(buffer, 0, client.ReceiveBufferSize);
            return Encoding.ASCII.GetString(buffer, 0, bytesRead);
        }

    }
}
