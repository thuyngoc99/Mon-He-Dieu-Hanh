using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cau2_Client
{
    class Program
    {
        private const int BUFFER_SIZE = 9999;
        private const int PORT_NUMBER = 1024;
        static ASCIIEncoding encoding = new ASCIIEncoding();
        static void Main(string[] args)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect("127.0.0.1", PORT_NUMBER);
                Stream stream = client.GetStream();
                Console.WriteLine("Ket noi den Server");
                Console.WriteLine("Nhap ten: ");
                string str = Console.ReadLine();
                byte[] data = encoding.GetBytes(str);
                stream.Write(data, 0, data.Length);
                data = new byte[BUFFER_SIZE];
                stream.Read(data, 0, BUFFER_SIZE);
                //string str1 = encoding.GetString(data);
                Console.WriteLine(encoding.GetString(data));

                stream.Close();
                client.Close();

            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            Console.ReadKey();
        }
    }
}
