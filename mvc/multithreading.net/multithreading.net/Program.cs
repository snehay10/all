
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreading.net
{

    public  class Program
    {
         
       public static void Main(string[] args)
        {
            Thread th1 = new Thread(table1);
            Thread th2 = new Thread(alpha);

            th1.Start();
            th2.Start();

            th1.Join();
            th2.Join();
            Console.WriteLine("Main thread completed");
            Console.ReadLine();
        }

        public static void table1()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i * i);
            }
        }


        public static  void alpha()
        {
            for(int i= 1; i < 10; i++)
            {
                Console.WriteLine(i+"*");
            }
        }
    }
}
