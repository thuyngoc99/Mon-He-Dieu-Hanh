using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        public static void Main() {
            var pipe = new NamedPipeServerStream("Pipe", PipeDirection.InOut);
            pipe.WaitForConnection();
            byte[] data = Encoding.Unicode.GetBytes("Day la du lieu gui tu pipe server");
            pipe.Write(data, 0, data.Length);
            var data1 = new byte[1000];
            pipe.Read(data1, 0, 1000);
            Console.WriteLine(Encoding.Unicode.GetString(data1));
            Console.Read();
        }
    }
}
