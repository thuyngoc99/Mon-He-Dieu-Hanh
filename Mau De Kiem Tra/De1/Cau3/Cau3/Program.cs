using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cau3
{
    class Program
    {
        static int amount = 50;
        static object s1 = new object();
        static object s2 = new object();
        static void Main(string[] args)
        {
            Thread tangSo = new Thread(TangSo);
            Thread giamSo = new Thread(GiamSo);
            tangSo.Start();
            giamSo.Start();
            Console.ReadKey();
        }

        static void TangSo()
        {
            Console.WriteLine("Trong phuong thuc tang so: ");
           
                lock (s1)
                {
                    //Console.WriteLine("TangSo : lock(s1)");
                    amount++;
                    if (amount > 0)
                    {
                        Console.WriteLine("TangSo: lock(1) {0}", amount);
                        Thread.Sleep(100);
                    }
                    lock (s2)
                    {
                        amount--;
                        //if (amount > 0)
                        //{
                        //    Console.WriteLine("TangSo: lock(2) {0}", amount);
                        //    Thread.Sleep(100);
                        //}
                    }
                }
            
        }
        
        static void GiamSo()
        {
            Console.WriteLine("Trong phuong thuc giam so: ");
            
                lock (s2)
                {
                    amount--;
                    //if(amount > 0)
                    //{
                    //    Console.WriteLine("GiamSo: lock(2) {0}", amount);
                    //    Thread.Sleep(100);
                    //}
                    Console.WriteLine("GiamSo: lock(2) {0}", amount);
                    Thread.Sleep(100);
                    lock (s1)
                    {
                        amount++;
                        //if (amount > 0)
                        //{
                        //    Console.WriteLine("GiamSo: lock(1) {0}", amount);
                        //    Thread.Sleep(100);
                        //}
                        //Console.WriteLine("GiamSo: lock(1) {0}", amount);
                        //Thread.Sleep(100);
                    }
                }
            
        }
    }
}
