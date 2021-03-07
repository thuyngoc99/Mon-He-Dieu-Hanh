using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] burst_time = new int[20];
            int[] waiting_time = new int[20];
            float avg_waitingTime = 0;
            Console.Write("Nhap so tien trinh (toi da 20):");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap thoi gian thuc thi cua tien trinh\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Process {0}: ",(i + 1), "\n");
                burst_time[i] = Convert.ToInt32(Console.ReadLine());
            }

            waiting_time[0] = 0;    

            //Thời gian chờ
            for (int i = 1; i < n; i++)
            {
                waiting_time[i] = 0;
                for (int j = 0; j < i; j++)
                    waiting_time[i] += burst_time[j];  
            }

            Console.Write("\nProcess\t\tBurst Time\tWaiting Time");

            for (int i = 0; i < n; i++)
            {
                avg_waitingTime += waiting_time[i];
                Console.Write("\nP{0}\t\t{1}\t\t{2}", i + 1, burst_time[i], waiting_time[i]);
            }
            
            Console.Write("\n\nThoi gian cho trung binh: {0}", avg_waitingTime /= n);
            Console.ReadKey();
        }
    }
}
