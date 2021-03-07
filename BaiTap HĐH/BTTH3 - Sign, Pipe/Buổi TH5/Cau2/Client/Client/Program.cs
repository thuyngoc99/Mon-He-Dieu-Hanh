using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        public static void Main() {
            var pipe = new System.IO.Pipes.NamedPipeClientStream("Pipe");
            pipe.Connect();
            var data1 = new byte[1000];
            pipe.Read(data1, 0, 1000);
            Console.WriteLine(Encoding.Unicode.GetString(data1));
            byte[] data = Encoding.Unicode.GetBytes("Day la du lieu gui tu pipe client");
            pipe.Write(data, 0, data.Length);
            Console.Read();
        }
    }
}
