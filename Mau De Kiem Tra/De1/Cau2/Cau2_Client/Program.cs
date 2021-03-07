using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cau2_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 2008;
            String host = "127.0.0.1";
            UdpClient udp = new UdpClient();
            udp.Connect(host, port);
            while (true)
            {
                Console.Write("Nhap noi dung:");
                String message = Console.ReadLine();
                if (message == "exit") break;
                Byte[] data = Encoding.ASCII.GetBytes(message);
                udp.Send(data, data.Length);
            }
            Console.Read();

        }
    }
}
