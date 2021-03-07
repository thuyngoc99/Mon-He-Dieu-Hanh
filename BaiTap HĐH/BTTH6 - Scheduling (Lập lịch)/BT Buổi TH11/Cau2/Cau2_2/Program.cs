using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arriveTime = new int[10];
            int[] burstTime = new int[10];
            int[] priority = new int[10];
            int[] rt = new int[10];
            int i, n, smallest, time, remain;
            float avg = 0;

            Console.WriteLine("\nNhap so tien trinh: ");
            n = Convert.ToInt32(Console.ReadLine());
            remain = n;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap thoi gian den cho tien trinh {0}: ", i + 1);
                arriveTime[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nNhap thoi gian thuc thi cho tien trinh {0}: ", i + 1);
                burstTime[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nNhap do uu tien cho tien trinh {0}: ", i + 1);
                priority[i] = Convert.ToInt32(Console.ReadLine());

                rt[i] = burstTime[i];
            }

            priority[9] = 11;
            Console.WriteLine("\nProcess\t Arrive Time\t Priority\t Burst Time\t Waiting Time\n");
            for (time = 0; remain != 0; time++)
            {
                smallest = 9;
                for (i = 0; i < n; i++)
                {
                    if (arriveTime[i] <= time && priority[i] < priority[smallest] && rt[i] > 0)
                    {
                        smallest = i;
                    }
                }
                rt[smallest]--;
                if (rt[smallest] == 0)
                {
                    remain--;
                    Console.WriteLine("\nP[{0}]\t\t{1}\t\t{2}\t\t{3}\t\t{4}", smallest + 1, arriveTime[smallest], priority[smallest], burstTime[smallest], time + 1 - arriveTime[smallest] - burstTime[smallest]);
                    avg += time + 1 - arriveTime[smallest] - burstTime[smallest];
                }
            }
            Console.WriteLine("\nThoi gian cho doi trung binh = {0}", avg * 1.0 / n);
            Console.Read();
        }
    }
}
