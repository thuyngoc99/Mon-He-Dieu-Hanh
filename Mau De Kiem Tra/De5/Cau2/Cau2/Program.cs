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
        static void Main(string[] args)
        {
            Thread x = new Thread(writeX);
            Thread y = new Thread(writeY);
            Thread z = new Thread(writeZ);
            x.Start();
            z.Start();
            z.Join();
            y.Start();
            Console.Read();
        }

        static void writeX()
        {
            for(int i = 0; i < 30; i++)
            {
                Console.Write("x");
            }
        }
        static void writeY()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.Write("y");
            }
        }
        static void writeZ()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.Write("z");
            }
        }
    }
}
