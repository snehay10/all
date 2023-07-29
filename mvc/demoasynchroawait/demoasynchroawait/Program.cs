using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demoasynchroawait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            task1();
            task2();
            task3();
            task4();
            Console.WriteLine("Main thread running...........");
            Console.ReadLine();
        }

        public  static async void task1()
        {
           await Task.Run(() =>
            {
                Console.WriteLine("Task 1 Started");
                Thread.Sleep(2000);
                Console.WriteLine("Task 1 completed");
            });    
        }

        public static  async void task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 2 Started");
                Thread.Sleep(3000);
                Console.WriteLine("Task 2 Completed");
            }
            );
           
        }

        public async static void task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 3 Started");
                Thread.Sleep(1000);
                Console.WriteLine("Task 3 Completed");
            });
           
        }

        public async static void task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 4 Started");
                Thread.Sleep(6000);
                Console.WriteLine("Task 4 completed");
            });
           
        }
    }
}
