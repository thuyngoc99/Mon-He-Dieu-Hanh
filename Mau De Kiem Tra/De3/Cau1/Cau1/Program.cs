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
            Thread x = new Thread(goY);
            x.Start();
            for(int i = 0; i < 50; i++)
            {
                Console.Write("x");
            }
            Console.Read();
        }

        static void goY()
        {
            for(int i = 0; i < 50; i++)
            {
                Console.Write("y");
            }
        }
    }
}
