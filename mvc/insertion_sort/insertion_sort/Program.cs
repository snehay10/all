using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertion_sort
{
    internal class Program
    { 
        public void insertion_sort(int[] arr)
        {
            int temp = 0,j;
            for (int i = 0; i < arr.Length; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j+1] = temp;
            }
            for(int g=0;g<arr.Length; g++)
            {
                Console.WriteLine(arr[g]);
            }
        }
        static void Main(string[] args)
        {
            Program p= new Program();
            int[] arr = { 6, 4, 7, 8, };
            p.insertion_sort(arr);
            Console.ReadLine();
        }
    }
}
