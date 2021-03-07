
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, total = 0, x, counter = 0, time_quantum;
            int wait_time = 0;
            int[] arrival_time = new int[10];
            int[] burst_time = new int[10];
            int[] temp = new int[10];
            Console.WriteLine("\nNhap so tien trinh:\t");
            n = Convert.ToInt32(Console.ReadLine());
            x = n;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\nTien trinh [{0}]\n", i + 1);

                Console.WriteLine("Nhap thoi gian den:\t");
                arrival_time[i] = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Nhap thoi gian thuc thi:\t");
                burst_time[i] = Convert.ToInt32(Console.ReadLine());

                temp[i] = burst_time[i];
            }

            Console.WriteLine("\nNhap q:\t");
            time_quantum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nProcess ID\t\tBurst Time\t Waiting Time");
            for (total = 0, i = 0; x != 0;)
            {
                if (temp[i] <= time_quantum && temp[i] > 0)
                {
                    total = total + temp[i];
                    temp[i] = 0;
                    counter = 1;
                }
                else if (temp[i] > 0)
                {
                    temp[i] = temp[i] - time_quantum;
                    total = total + time_quantum;
                }
                if (temp[i] == 0 && counter == 1)
                {
                    x--;
                    Console.WriteLine("\nProcess{0}\t\t{1}\t\t{2}", i + 1, burst_time[i], total - arrival_time[i] - burst_time[i]);
                    wait_time = wait_time + total - arrival_time[i] - burst_time[i];
                    counter = 0;
                }
                if (i == n - 1)
                {
                    i = 0;
                }
                else if (arrival_time[i + 1] <= total)
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
            }
            Console.WriteLine("\nThoi gian cho trung binh:\t{0}", wait_time * 1.0 / n);
            Console.Read();
        }
    }
}
