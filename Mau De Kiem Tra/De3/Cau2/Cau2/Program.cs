using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cau2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "main";
            Thread ten = new Thread(Go);
            ten.Name = "worker";
            ten.Start();
            Go();
        }

        static void Go()
        {
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine("Chao tu " + Thread.CurrentThread.Name);
            }
            Console.Read();
        }
    }
}
