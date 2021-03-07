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
            //ConsoleCancelEventHandler dai dien cho phuong thuc se xu ly su kien cua CancelKeyPress
            Console.CancelKeyPress += new ConsoleCancelEventHandler(Console_CancelKeyPress); 
            int count = 0;
            while (true)
            {
                Console.WriteLine(++count);
                System.Threading.Thread.Sleep(500);
            }
        }

        //ConsoleCancelEventArgs Cung cấp dữ liệu cho sự kiện Console.CancelKeyPress
        static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e) 
        {
            e.Cancel = true;
            var end = DateTime.Now;
            Console.WriteLine("Ung ung da chay duoc {0:000.000} giay.", (end - start).TotalMilliseconds / 1000); //TotalMilliseconds tong so ml giay
        }
    }

    
}
