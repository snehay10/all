using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of array element :");
            int n=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Array elements :");
            
            int[] arr=new int[n];
            for(int i=0; i < n; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter Number which u want to search :");
            int ch = Convert.ToInt32(Console.ReadLine());
            int index = 0;
            for (int j=0; j < arr.Length; j++)
            {
                if(ch == arr[j])
                {
                    index = j;
                    break;
                }
            }
            if (index == 0)
            {
                Console.WriteLine("element not found");
            }
            else
            {
                Console.WriteLine($"element is found at {index} position");
            }
            Console.ReadLine();
        }
    }
}
