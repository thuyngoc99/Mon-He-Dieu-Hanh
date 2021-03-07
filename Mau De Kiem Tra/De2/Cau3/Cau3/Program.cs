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
        static object s1 = new object();
        static int amount = 50;
        static void Main(string[] args)
        {
            Thread tang = new Thread(new ThreadStart(Tang));
            Thread giam = new Thread(new ThreadStart(Giam));
            tang.Start();
            giam.Start();
            Console.ReadKey();
        }

        static void Tang()
        {
            for(int i = 0; i < 20; i++)
            {
                lock (s1)
                {
                    amount++;
                    if(amount > 0)
                    {
                        Console.Write(amount + "\t");
                        Thread.Sleep(100);
                    }
                }
            }
        }

        static void Giam()
        {
            for(int i = 0; i < 20; i++)
            {
                lock (s1)
                {
                    amount--;
                }
            }
        }
    }
}
