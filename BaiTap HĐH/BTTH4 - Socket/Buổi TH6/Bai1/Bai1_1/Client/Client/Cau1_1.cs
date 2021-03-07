using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Cau1_1
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
                    Console.Write("Nhap n : ");

                    string n = Console.ReadLine();
                    writer.WriteLine(n);
                    Console.WriteLine("Tong 1 + 3 + 5 + ... + (2n + 1) : " + reader.ReadLine());
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
