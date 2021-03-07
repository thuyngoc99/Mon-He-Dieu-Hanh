using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] waiting = new int[10];
            //int[] turnaround = new int[10];
            //int[] completion = new int[10];
            //int[] a = new int[10];
            //int[] b = new int[10];
            //int[] x = new int[10];

            //int i, j, smallest, count = 0, time, n;
            //int avg = 0, tt = 0, end;

            //Console.Write("Nhap so tien trinh : ");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("Nhap thoi gian den cho tien trinh {0} : ", i + 1);
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("Nhap thoi gian den cho tien trinh {0} : ", i + 1);
            //    b[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (i = 0; i < n; i++)
            //    x[i] = b[i];

            //b[9] = 9999;
            //for (time = 0; count != n; time++)
            //{
            //    smallest = 9;
            //    for (i = 0; i < n; i++)
            //    {
            //        if (a[i] <= time && b[i] < b[smallest] && b[i] > 0)
            //            smallest = i;
            //    }
            //    b[smallest]--;

            //    if (b[smallest] == 0)
            //    {
            //        count++;
            //        end = time + 1;
            //        //completion[smallest] = end;
            //        waiting[smallest] = end - a[smallest] - x[smallest];
            //        //turnaround[smallest] = end - a[smallest];
            //    }
            //}
            //Console.Write("\n\nProcess\t\tArrive Time\tBurse Time\tWaiting Time\n");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("P{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\t\n", i + 1, x[i], a[i], waiting[i],turnaround[i], completion[i]);
            //    //cout << "p" << i + 1 << "\t\t" << x[i] << "\t\t" << a[i] << "\t\t" << waiting[i] << "\t\t" << turnaround[i] << "\t\t" << completion[i] << endl;
            //    avg = avg + waiting[i];
            //    //tt = tt + turnaround[i];
            //}
            //Console.Write("\nAverage waiting time = {0}", avg / n);
            ////cout << "  Average Turnaround time =" << tt / n << endl;
            //Console.Read();


            //    int[] ari = new int[10];
            //    int[] bur = new int[10];
            //    int[] procs = new int[10];
            //    int[] waiting = new int[10];
            //    int[] finish = new int[10];
            //    //int[] x = new int[10];
            //    int n, i, total = 0, temp, small, k;

            //    float tavg = 0.0f, wavg = 0.0f;

            //    Console.Write("Nhap so tien trinh : ");
            //    n = Convert.ToInt32(Console.ReadLine());

            //    for (i = 0; i < n; i++)

            //    {
            //        Console.Write("Nhap thoi gian den cho tien trinh {0} : ", i + 1);
            //        ari[i] = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("Nhap thoi gian thuc thi cho tien trinh {0} : ", i + 1);
            //        bur[i] = Convert.ToInt32(Console.ReadLine());



            //        waiting[i] = 0;

            //        total += bur[i];

            //    }

            //    for (i = 0; i < n; i++)

            //    {

            //        for (int j = i + 1; j < n; j++)

            //        {

            //            if (ari[i] > ari[j])

            //            {

            //                temp = ari[i];

            //                ari[i] = ari[j];

            //                ari[j] = temp;

            //                temp = bur[i];

            //                bur[i] = bur[j];

            //                bur[j] = temp;

            //            }

            //        }

            //    }

            //    for (i = 0; i < total; i++)

            //    {

            //        small = 3200;

            //        for (int j = 0; j < n; j++)

            //        {

            //            if ((bur[j] != 0) && (ari[j] <= i) && (bur[j] < small))

            //            {

            //                small = bur[j];
            //                k = j;

            //            }

            //        }

            //        bur[k]--;

            //        procs[i] = k;

            //    }

            //    k = 0;

            //    for (i = 0; i < total; i++)

            //    {

            //        for (int j = 0; j < n; j++)

            //        {

            //            if (procs[i] == j)

            //            {

            //                finish[j] = i;

            //                waiting[j]++;

            //            }

            //        }

            //    }

            //    for (i = 0; i < n; i++)

            //    {

            //        Console.Write("\n PROCESS {0}:-FINISH TIME==> {1} TURNAROUND TIME==>{2} WAITING TIME==>{3}\n", i + 1, finish[i] + 1, (finish[i] - ari[i]) + 1, (((finish[i] + 1) - waiting[i]) - ari[i]));

            //        wavg = wavg + (((finish[i] + 1) - waiting[i]) - ari[i]);

            //        tavg = tavg + ((finish[i] - ari[i]) + 1);

            //    }

            //    Console.Write("\n WAvG==>\t{0}\n TAVG==>\t{1}\n", (wavg / n), (tavg / n));
            //    Console.Read();
            //}

            int[] at = new int[10];
            int[] b = new int[10];
            int[] cpu = new int[10];
            int[] wt = new int[10];
            int[] tat = new int[10];
            int[] et = new int[10];
            int[] st = new int[10];
            int[] rt = new int[10];
           
            int i, j, smallest, count = 0, time, n;
            int avg = 0, tt = 0, end;

            Console.Write("Nhap so tien trinh : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Nhap thoi gian den cho tien trinh {0} : ", i + 1);
                at[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                Console.Write("Nhap thoi gian thuc thi cho tien trinh {0} : ", i + 1);
                b[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (i = 0; i < n; i++)
                cpu[i] = b[i];

            b[9] = 9999;

            for (time = 0; count != n; time++)
            {
                smallest = 9;
                for (i = 0; i < n; i++)
                {
                    if (at[i] <= time && b[i] < b[smallest] && b[i] > 0)
                        smallest = i;
                }
                b[smallest]--;

                st[0] = 0;

                if (b[smallest] == 0)
                {
                    count++;
                    end = time + 1;
                    et[smallest] = end;
                    st[smallest] = et[smallest] - cpu[smallest];
                    wt[smallest] = end - at[smallest] - cpu[smallest];
                    rt[smallest] = end - at[smallest] - cpu[smallest];
                    tat[smallest] = end - at[smallest];
                }
            }

            Console.Write("\nP# \tAT \tCPU \tST \tET \tWT \tRT \tTAT");

            for (i = 0; i < n; i++)
            {

                Console.Write("\nP{0} \t{1} \t{2} \t{3} \t{4} \t{5} \t{6} \t{7}", i + 1, at[i], cpu[i], st[i], et[i], wt[i], rt[i], tat[i]);
                avg = avg + wt[i];
                tt = tt + tat[i];
            }

            Console.Write("\nAverage Response Time = {0}", avg / n);
            Console.Write("\nAverage Waiting time = {0}\n", avg / n);
            Console.Write("Average Turnaround time = {0}", tt / n);
            Console.Read();
        }
    }
}
