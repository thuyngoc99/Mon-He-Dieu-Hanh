using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cau2
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udp = new UdpClient(2008);
            while (true)
            {
                IPEndPoint ip = new IPEndPoint(IPAddress.Any, 0);
                byte[] data = udp.Receive(ref ip);
                string message = Encoding.ASCII.GetString(data);
                Console.WriteLine("Dia chi IP: {0} - Noi dung: {1}", ip.Address, message);
            }
            Console.Read();
        }
    }
}
