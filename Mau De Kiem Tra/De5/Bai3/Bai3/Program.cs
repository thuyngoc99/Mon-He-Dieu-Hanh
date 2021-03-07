using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static object x = new object();
        static object y = new object();
        static int amount = 60;
        static void Main(string[] args)
        {
            Thread a = new Thread(TangSo);
            Thread b = new Thread(GiamSo);
            a.Start();
            b.Start();
            Console.Read();

        }

        static void TangSo()
        {
            Console.WriteLine("Trong phuong thuc tang so: ");
            lock (x)
            {
                amount++;
                if (amount > 0)
                {
                    Console.WriteLine("Tang so lock(x): " + amount);
                    Thread.Sleep(100);
                }
                lock (y)
                {
                    amount--;
                }
            }
        }

        static void GiamSo()
        {
            Console.WriteLine("Trong phuong thuc giam so");
            lock (y)
            {
                amount--;
                Console.WriteLine("Giam so lock(y): " + amount);
                Thread.Sleep(100);
                lock (x)
                {
                    amount++;
                }
            }
        }
    }
}
