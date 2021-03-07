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
        static DateTime start;
        static void Main(string[] args)
        {
            start = DateTime.Now;
            Console.CancelKeyPress += new ConsoleCancelEventHandler(ConsoleCancelEventHandler);
            int amount = 0;
            while (true)
            {
                Console.WriteLine(++amount);
                Thread.Sleep(200);
            }
        }

        static void ConsoleCancelEventHandler(object x, ConsoleCancelEventArgs e)
        {
            e.Cancel = true;
            DateTime end = DateTime.Now;
            Console.WriteLine("Thong bao: Chuong trinh da chay duoc {0:000.000} giay", (end - start).TotalMilliseconds / 1000);
        }
    }
}
