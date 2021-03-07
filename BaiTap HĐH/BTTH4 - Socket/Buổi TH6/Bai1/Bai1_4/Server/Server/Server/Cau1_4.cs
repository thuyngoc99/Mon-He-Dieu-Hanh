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
    class Cau1_4
    {
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 9999;

        static ASCIIEncoding encoding = new ASCIIEncoding();

        static void Main(string[] args)
        {
            try
            {
                IPAddress address = IPAddress.Parse("127.0.0.1");
                TcpListener listener = new TcpListener(address, PORT_NUMBER);

                listener.Start();

                Console.WriteLine("Waiting for a connection....");
                Socket socket = listener.AcceptSocket();

                var stream = new NetworkStream(socket);
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream);
                writer.AutoFlush = true;

                while (true)
                {
                    int n = Convert.ToInt32(reader.ReadLine());
                    Console.WriteLine("n la : " + n);
                  
                    writer.WriteLine(fibonacci(n));

                }

                socket.Close();
                listener.Stop();
            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            Console.Read();

        }

        public static int fibonacci(int n)
        {
            if (n == 1 || n == 2) return 1;
            return (fibonacci(n - 1) + fibonacci(n - 2));
        }
    }
}
