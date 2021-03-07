using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Cau2_2
    {
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 9999;

        static ASCIIEncoding encoding = new ASCIIEncoding();

        public static void Main()
        {

            try
            {
                TcpClient client = new TcpClient();

                client.Connect("127.0.0.1", PORT_NUMBER);
                Stream stream = client.GetStream();

                Console.WriteLine("Connected to Server.");
                while (true)
                {
                    var reader = new StreamReader(stream);
                    var writer = new StreamWriter(stream);
                    writer.AutoFlush = true;
                    Console.Write("Nhap a : ");
                    string a = Console.ReadLine();
                    Console.Write("Nhap b : ");
                    string b = Console.ReadLine();

                    writer.WriteLine(a);
                    writer.WriteLine(b);

                    Console.WriteLine("Tong lap phuong cua a va b : " + reader.ReadLine());
                }

                stream.Close();
                client.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }

            Console.Read();
        }
    }
}
