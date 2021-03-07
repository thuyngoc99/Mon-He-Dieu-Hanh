using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cau3
{
    class Program
    {
        static object x = new object();
        static object y = new object();
        static void Main(string[] args)
        {
            Thread x = new Thread(TestSo1);
            Thread y = new Thread(TestSo2);
            x.Start();
            y.Start();
            Console.Read();
        }

        static void TestSo1()
        {
            Console.WriteLine("Trong phuong thuc TestSo1: ");
            lock (x)
            {
                Console.WriteLine("TestSo1 lock(x)");
                Thread.Sleep(1000);
                lock (y)
                {
                    Console.WriteLine("TestSo1 lock(y)");
                }
            }
        }

        static void TestSo2()
        {
            Console.WriteLine("Trong phuong thuc TestSo2: ");
            lock (y)
            {
                Console.WriteLine("TestSo2 lock(y)");
                Thread.Sleep(1000);
                lock (x)
                {
                    Console.WriteLine("TestSo2 lock(x)");
                }
            }
        }
    }
}
