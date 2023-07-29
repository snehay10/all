using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryserach
{
    internal class Program
    {

        public int binary_search(int data, int[] arr)
        {
            int left = 0;
            int right = arr.Length;
            while(left < right)
            {
                int mid = (left+right)/2;
                if (data == arr[mid] )
                {
                    return mid;
                }
                else if(data < arr[mid])
                {
                    left = mid + 1;
                }
                else if (data > arr[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    return -1;
                }
            }



            return 0;

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] arr = { 1, 2, 3 };
            int val = program.binary_search(90,arr);
            if (val == -1)
            {
                Console.WriteLine("element is not found");
            }
            else
            {
                Console.WriteLine($"element fount at {val} position");
            }
            Console.ReadLine();
        }
        
    }
}
