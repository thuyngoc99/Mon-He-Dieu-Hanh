using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cau5
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Go);
            ThreadPool.QueueUserWorkItem(Go, 123);
            Console.ReadKey();           
        }

        static void Go(object a)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread Callback:" + a);
                Thread.Sleep(200);
            }
        }
    }
}
