using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int time;
            int[] burst_time = new int[10];
            int[] arrival_time = new int[10];
            int sum_burstTime = 0, smallest, n, i;
            float sum_waiting = 0;
            Console.Write("Nhap so tien trinh : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("Nhap thoi gian den cho tien trinh {0} : ", i + 1);
                arrival_time[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap thoi gian thuc thi cho tien trinh {0} : ", i + 1);
                burst_time[i] = Convert.ToInt32(Console.ReadLine());
                sum_burstTime += burst_time[i];
            }
            burst_time[9] = 9999;

            Console.Write("\n\nProcess\t\tArrive Time\tBurse Time\tWaiting Time\n");
            for (time = 0; time < sum_burstTime;)
            {
                smallest = 9;
                for (i = 0; i < n; i++)
                {
                    if (arrival_time[i] <= time && burst_time[i] > 0 && burst_time[i] < burst_time[smallest])
                        smallest = i;
                }
                if (smallest == 9)
                {
                    time++;
                    continue;
                }
                Console.Write("P{0}\t\t{1}\t\t{2}\t\t{3}\t\n", smallest + 1, arrival_time[smallest], burst_time[smallest], time - arrival_time[smallest]);
                sum_waiting += time - arrival_time[smallest];
                time += burst_time[smallest];
                burst_time[smallest] = 0;
            }
            Console.Write("\nAverage waiting time = {0}", (sum_waiting * 1.0) / n);
            Console.Read();
        }
    }
}
