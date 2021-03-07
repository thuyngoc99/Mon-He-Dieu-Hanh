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
            Thread x = new Thread(inX);
            Thread y = new Thread(inY);
            Thread z = new Thread(inZ);
            x.Start();
            z.Start();
            z.Join();
            y.Start();
            Console.Read();
        }

        static void inX()
        {
            for(int i = 0; i < 20; i++)
            {
                Console.Write("x");
            }
        }
        static void inY()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write("y");
            }
        }
        static void inZ()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write("z");
            }
        }
    }
}
