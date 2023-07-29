using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class forloop
    {
        internal static void show()     //Static method 
        {
            int n;
            Console.WriteLine("Enter length of array : ");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Array elements : ");
            int[] a = new int[n];
            for(int i =0;i<n;i++)
            {
                a[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements of array : ");
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(a[i]);    
            }

        }
    }
}
