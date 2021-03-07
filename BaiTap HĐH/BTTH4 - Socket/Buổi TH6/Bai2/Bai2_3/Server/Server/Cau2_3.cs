using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Cau2_3
    {
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 9999;

        static ASCIIEncoding encoding = new ASCIIEncoding();

        public static void Main()
        {
            try
            {
                IPAddress address = IPAddress.Parse("127.0.0.1");

                TcpListener listener = new TcpListener(address, PORT_NUMBER);

                listener.Start();

                Console.WriteLine("Waiting for a connection...");

                Socket socket = listener.AcceptSocket();

                var stream = new NetworkStream(socket);
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream);
                writer.AutoFlush = true;

                while (true)
                {
                    int a = Convert.ToInt32(reader.ReadLine());
                    Console.WriteLine("a la : " + a);
                    int b = Convert.ToInt32(reader.ReadLine());
                    Console.WriteLine("b la : " + b);

                    writer.WriteLine(UCLN(a, b));

                }

                socket.Close();
                listener.Stop();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            Console.Read();
        }

        public static int UCLN(int a, int b)
        {
            if (a == 0 || b == 0) return a + b;
            while(a != b)
            {
                if (a > b) a = a - b;
                else if (b > a) b = b - a;
            }
            return a;
        }

    }
}
