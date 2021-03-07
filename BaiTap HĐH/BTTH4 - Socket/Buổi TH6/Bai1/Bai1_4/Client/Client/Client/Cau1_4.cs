using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Cau1_4
    {
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 9999;

        static ASCIIEncoding encoding = new ASCIIEncoding();

        static void Main(string[] args)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect("127.0.0.1", PORT_NUMBER);
                Stream stream = client.GetStream();

                while (true)
                {
                    var reader = new StreamReader(stream);
                    var writer = new StreamWriter(stream);
                    writer.AutoFlush = true;
                    Console.Write("Nhap n: ");

                    String n = Console.ReadLine();
                    writer.WriteLine(n);
                    Console.WriteLine("So fibonacci thu " + n + " la : " + reader.ReadLine());

                }
                stream.Close();
                client.Close();

            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            Console.Read();
        }
    }
}
