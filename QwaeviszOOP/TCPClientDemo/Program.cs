using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace TCPClientDemo
{
    public class Program
    {
        private static readonly int DEFAULT_PORT = 15899;

        private static void Main(string[] args)
        {
            string host = GetLocalIPAddress();
            int port = DEFAULT_PORT;
            bool successInit = true;
            try
            {
                if (args != null && args.Length == 1)
                {
                    string argument = args[0];
                    string[] arguments = argument.Split(":");
                    if (arguments.Length == 2)
                    {
                        host = arguments[0];
                        port = Int32.Parse(arguments[1]);
                    }
                    else if (arguments.Length == 1)
                    {
                        host = arguments[0];
                    }
                    else
                    {
                        successInit = false;
                    }
                }
            }
            catch (Exception e)
            {
                successInit = false;
            }
            if (successInit)
            {
                try
                {
                    TCPClientApplication application = new TCPClientApplication();
                    application.Connect(host, port);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
            else
            {
                PrintUsage(port);
            }
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private static void PrintUsage(int port)
        {
            Console.WriteLine("Usage: TCPClientDemo.exe {host}:{port}");
            Console.WriteLine("Host is optional. Default value: " + GetLocalIPAddress());
            Console.WriteLine("Port is optional. Default value: " + port);
        }

    }
}
