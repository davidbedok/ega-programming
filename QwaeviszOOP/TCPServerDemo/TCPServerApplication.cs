using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Collections;
using System.IO;

namespace TCPServerDemo
{
    public class TCPServerApplication
    {
        
        private IPAddress ipAddress;
        private int port;
        private TcpListener listener;

        public TCPServerApplication( string host, int port )
        {
            this.ipAddress = IPAddress.Parse(host);
            this.port = port;
        }

        public void Start()
        {
            this.listener = new TcpListener(this.ipAddress, this.port);
            this.listener.Start();
            Console.WriteLine("Server was started: " + this.listener.LocalEndpoint);
            Console.WriteLine("Waiting for a client to connect...");

            TcpClient client = this.listener.AcceptTcpClient();
            NetworkStream networkStream = client.GetStream();
            Console.WriteLine("Client connected.");

            while (true)
            {
                

                string command = this.ReadTextFromClient(client, networkStream);
                Console.WriteLine("Received command: " + command);
                this.WriteTextToClient(networkStream, "OK");

                if (command.Equals("exit"))
                {
                    Console.WriteLine("Exit...");
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
                            } else
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
            this.listener.Stop();
        }
        private string ReadTextFromClient(TcpClient client, NetworkStream networkStream)
        {
            
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead = networkStream.Read(buffer, 0, client.ReceiveBufferSize);
            return Encoding.ASCII.GetString(buffer, 0, bytesRead);
        }

        private void WriteTextToClient(NetworkStream networkStream, string text )
        {
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(text);
            networkStream.Write(bytesToSend, 0, bytesToSend.Length);
        }



    }
}
