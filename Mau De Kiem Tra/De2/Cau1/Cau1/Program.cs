using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1
{
    class Program
    {
        static DateTime start;
        static void Main(string[] args)
        {
            start = DateTime.Now;
            Console.CancelKeyPress += new ConsoleCancelEventHandler(Console_CanCel);
            int count = 0;
            while (true)
            {
                count++;
                Console.WriteLine(count);
                System.Threading.Thread.Sleep(400);
            }
        }

        static void Console_CanCel(object sender, ConsoleCancelEventArgs e)
        {
            e.Cancel = true;
            var end = DateTime.Now;
            Console.WriteLine("Ung dung da chay duoc {0:000.000} giay", (end - start).TotalMilliseconds / 1000);
        }
    }
}
