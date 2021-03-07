using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau2_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var pipe = new NamedPipeClientStream("pipe");
            pipe.Connect();
            byte[] data = new byte[1000];
            pipe.Read(data, 0, 1000);
            string str = Encoding.ASCII.GetString(data);
            Console.WriteLine(str);
            byte[] data1 = Encoding.ASCII.GetBytes("Xin chao, chao mung ban den voi Client");
            pipe.Write(data1, 0, data1.Length);
            Console.Read();
        }
    }
}
