using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cau3_Client
{
    class Program
    {
        private const int BUFFER_SIZE = 9999;
        private const int PORT_NUMBER = 1024;
        static void Main(string[] args)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect("127.0.0.1", PORT_NUMBER);
                Console.WriteLine("Da ket noi den Server");
                Stream stream = client.GetStream();
                while(true)
                {
                    Console.WriteLine("Nhap ten: ");
                    string str = Console.ReadLine();
                    var writer = new StreamWriter(stream);
                    var reader = new StreamReader(stream);
                    writer.AutoFlush = true;
                    writer.WriteLine(str);
                    string str1 = reader.ReadLine();
                    Console.WriteLine("Tuoi: " + str1);
                }
                client.Close();
                stream.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            Console.Read();
        }
    }
}
