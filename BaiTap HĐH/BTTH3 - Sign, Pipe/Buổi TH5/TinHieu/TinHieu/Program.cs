using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinHieu
{
    class Program
    {
        static DateTime start;
        public static void Main() {
            start = DateTime.Now;
            Console.CancelKeyPress += new ConsoleCancelEventHandler(Console_CancelKeyPress);
            int counter = 0; while (true) {
                Console.WriteLine(++counter);
                System.Threading.Thread.Sleep(500);
            }
        }
        static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e) {
            e.Cancel = true;
            var end = DateTime.Now;
            Console.WriteLine("This program ran for {0:000.000} seconds.", (end - start).TotalMilliseconds / 1000);
            Environment.Exit(0);
        }
    }
}
