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
        static int amount = 20;
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Incre));
            Thread t2 = new Thread(new ThreadStart(Decre));
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }

        static void Incre()
        {
            for(int i = 0; i < 100; i++)
            {
                amount++;
                if(amount > 0)
                {
                    Thread.Sleep(100);
                    Console.Write(amount + "\t"); 
                }
            }
        }

        static void Decre()
        {
            for(int i = 0; i < 100; i++)
            {
                amount--;
            }
        }
    }
}
