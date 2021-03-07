using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cau3
{
    class Program
    {
        private const int BUFFER_SIZE = 9999;
        private const int PORT_NUMBER = 1024;
        static void Main(string[] args)
        {
            try
            {
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                TcpListener listener = new TcpListener(ip, PORT_NUMBER);
                listener.Start();
                Console.WriteLine("Server bat dau o IP " + listener.LocalEndpoint);
                Console.WriteLine("Dang doi ket noi");
                Socket socket = listener.AcceptSocket();
                Console.WriteLine("Da ket noi tu IP " + socket.RemoteEndPoint);
                var stream = new NetworkStream(socket);
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream);
                writer.AutoFlush = true;
                {
                    while (true)
                    {
                        string str = reader.ReadLine();
                        Console.WriteLine("Ten: " + str);
                        Console.WriteLine("Nhap tuoi: ");
                        string str1 = Console.ReadLine();
                        writer.WriteLine(str1);
                        if (str == "exit") break;
                    }
                    stream.Close();
                    listener.Stop();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            Console.Read();
        }
    }
}
