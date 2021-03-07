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
        static int amount = 20;
        static void Main(string[] args)
        {
            Thread x = new Thread(tang);
            Thread y = new Thread(giam);
            x.Start();
            y.Start();
            Console.Read();
        }

        static void tang()
        {
            for(int i = 0; i < 30; i++)
            {
                lock (x)
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

        static void giam()
        {
            for(int i = 0; i < 30; i++)
            {
                lock (x)
                {
                    amount--;
                }
            }
        }
    }
}
