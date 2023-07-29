using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort
{
    internal class Program
    {
        public void bubble_sort(int[] arr)
        {
            int len = arr.Length;
            int temp = 0;
            int flag;
            for(int i =0; i < len;i++)
            {
                flag = 0;
                for (int j=0;j<len-1-i;j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flag = 1;
                    }
                }
                if (flag ==0)
                {
                    break;
                }
            }
            for(int y=0;y<arr.Length;y++)
            {
                Console.WriteLine(arr[y]);
            }
        }
                  
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = { 78,7,6,5,4,3,2};
            p.bubble_sort(arr);
            Console.ReadLine();

        }
    }
}
