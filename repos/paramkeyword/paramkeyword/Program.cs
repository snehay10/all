using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace paramkeyword
{
     class Program
    {
       
             void show(params int[] a)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }
            }

        public static void Main(String[] args)
        {
            Console.WriteLine("Enter length of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter array ");
            for (int i = 0; i < n ; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Program p = new Program();

            p.show(a);
        }


        
    }
}
