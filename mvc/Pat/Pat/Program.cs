using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of elements : ");
            int len=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array elements : ");
            int[] a=new int[len];
            for (int i = 0; i < len; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter searching elements : ");
            int ch= Convert.ToInt32(Console.ReadLine());
            binarySearch b = new binarySearch();
            int k = b.show(a,len,ch);
            Console.WriteLine($"{ch} present at {k} index");
            Console.ReadLine();
        }
    }
}