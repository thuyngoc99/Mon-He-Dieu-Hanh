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
        static int amount = 40;
        static object x = new object();
        static void Main(string[] args)
        {
            Thread x = new Thread(Tang);
            Thread y = new Thread(Giam);
            x.Start();
            y.Start();
            Console.Read();
        }

        static void Tang()
        {
            for(int i = 0; i < 20; i++)
            {
                lock (x)
                {
                    amount++;
                    if (amount > 0)
                    {
                        Console.Write(amount + "\t");
                        Thread.Sleep(200);
                    }
                }
            }
        }

        static void Giam()
        {
            for(int i = 0; i < 20; i++)
            {
                lock (x)
                {
                    amount--;
                }
            }
        }
    }
}
