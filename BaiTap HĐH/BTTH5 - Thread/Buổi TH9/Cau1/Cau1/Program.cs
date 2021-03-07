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
            Thread t = new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread t start");
            });
            t.IsBackground = true;
            t.Start();
            Console.WriteLine("Thread Main ending...");
            Console.ReadKey();
        }
    }
}
