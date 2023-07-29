using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace monitorfunctions
{
    internal class Program
    {
       static  object obj = new object();
        static void Main(string[] args)
        {
            Thread th1 = new Thread(task1);
            Thread th2 = new Thread(task2);

            th1.Start();
            th2.Start();

            th2.Join();
            th2.Join();

            Console.ReadLine();



        }


        public static void task1()
        {
            lock(obj)
            {
                Console.WriteLine("task1 started .......");
                Thread.Sleep(2000);
                Monitor.PulseAll(obj);
                Console.WriteLine("task1 completed......");

            }

        }

        public static void task2()
        {
            lock(obj)
            {
                Console.WriteLine("waiting for signal ...");
                Monitor.Wait(obj);
                Console.WriteLine("waiting thread completed task");
            }

        }
    }
}
