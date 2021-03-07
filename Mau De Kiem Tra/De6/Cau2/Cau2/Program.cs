using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pipe = new NamedPipeServerStream("pipe", PipeDirection.InOut);
            pipe.WaitForConnection();
            byte[] data = Encoding.ASCII.GetBytes("Xin chao, chao mung ban toi Server");
            pipe.Write(data, 0, data.Length);
            byte[] data1 = new byte[1000];
            pipe.Read(data1, 0, 1000);
            string str = Encoding.ASCII.GetString(data1);
            Console.WriteLine(str);
            Console.Read();
        }
    }
}
