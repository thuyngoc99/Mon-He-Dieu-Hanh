using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cau1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "main";
            Thread x = new Thread(ten);
            x.Name = "worker";
            x.Start();
            ten();
            Console.Read();
        }

        static void ten()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Xin chao " + Thread.CurrentThread.Name);
            }
        }
    }
}
