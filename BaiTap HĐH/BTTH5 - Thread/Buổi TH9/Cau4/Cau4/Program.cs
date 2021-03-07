using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cau4
{
    class Program
    {
        static object syncObj1 = new object();
        static object syncObj2 = new object();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Go);
            Thread t2 = new Thread(Run);
            t1.Start();
            t2.Start();
            Console.Read();
        }

        static void Go()
        {
            Console.WriteLine("Inside Go method");
            lock (syncObj1)
            {
                Console.WriteLine("Go: lock(syncObj1)");
                Thread.Sleep(100);
                lock (syncObj2)
                {
                    Console.WriteLine("Go: lock(syncObj2)");
                }
            }
        }

        static void Run()
        {
            Console.WriteLine("Inside Run method");
            lock (syncObj2)
            {
                Console.WriteLine("Run: lock(syncObj2)");
                Thread.Sleep(100);
                lock (syncObj1)
                {
                    Console.WriteLine("Run: lock(syncObj1)");
                }
            }
        }
    }
}
