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
        private const int PORT_NUMBER = 1024;
        private const int BUFFER_SIZE = 9999;
        static ASCIIEncoding encoding = new ASCIIEncoding();
        static void Main(string[] args)
        {
            try
            {
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                TcpListener listener = new TcpListener(ip, PORT_NUMBER);
                listener.Start();
                Console.WriteLine("Server bat dau o " + listener.LocalEndpoint);
                Console.WriteLine("Dang ket noi");
                Socket socket = listener.AcceptSocket();
                Console.WriteLine("Da ket noi tu ip " + socket.RemoteEndPoint);
                byte[] data = new byte[BUFFER_SIZE];
                socket.Receive(data);
                string str = encoding.GetString(data);
                Console.WriteLine("Xin chao "+ str);
                Console.WriteLine("Nhap tuoi: ");
                string str1 = Console.ReadLine();
                //data = encoding.GetBytes("Your age: " + str1);
                socket.Send(encoding.GetBytes("Your age: " + str1));

                socket.Close();
                listener.Stop();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            Console.ReadKey();
        }
    }
}
