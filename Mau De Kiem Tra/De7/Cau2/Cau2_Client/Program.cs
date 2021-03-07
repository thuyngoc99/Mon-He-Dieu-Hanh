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
            string host = "127.0.0.1";
            UdpClient udp = new UdpClient();
            udp.Connect(host, port);
            while (true)
            {
                Console.WriteLine("Nhap noi dung: ");
                string str = Console.ReadLine();
                if (str == "exit") break;
                byte[] data = Encoding.ASCII.GetBytes(str);
                udp.Send(data, data.Length);
            }
        }
    }
}
