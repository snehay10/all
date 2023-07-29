using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bbs
{
    internal class Program
    {

        public void bb_sort(int[] arr)
        {
            int len= arr.Length,temp=0,f=0;
          for(int i=0;i<len-1;i++)
            {
                for(int j=0;j<len-1-i;j++)
                {
                    
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        f = 1;
                    }
                }
                if(f == 0)
                {
                    Console.WriteLine("array is already sorted .........");
                    break;
                }
            }
          for(int k=0;k<len;k++)
            {
                Console.WriteLine(arr[k]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements : ");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array elements :");
            int[] arr = new int[n];
            for(int i=0;i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Program p = new Program();
            p.bb_sort(arr);
            Console.ReadLine();

        }
    }
}
