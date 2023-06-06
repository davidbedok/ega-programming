using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;

namespace TCPServerAdvancedDemo
{
    public class TCPServerApplication
    {

        private IPAddress ipAddress;
        private int port;
        private TcpListener listener;

        public TCPServerApplication(string host, int port)
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

            while (true)
            {
                TCPClientThread clientThread = new TCPClientThread(this.listener.AcceptTcpClient(), this.Kill);
                Thread t = new Thread(new ThreadStart(clientThread.Run));
                t.IsBackground = true;
                t.Start();
                Console.WriteLine("Client connected..");
            }
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

        private void Kill()
        {
            this.listener.Stop();
        }


    }
}
