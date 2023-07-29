using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort
{
    internal class Program
    {

       \
        public void selection_sort(int[] arr)
        {
            int n= arr.Length,temp=0;
            for(int i=0;i<n-1; i++)
            {
                int min = i;
                for(int j =i+1;j<n-1-i;j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if(min!= i)
                {
                    temp = arr[i]; arr[i] = arr[min]; arr[min] = temp;
                }
            }
            for(int h=0;h<n-1;h++)
            {
                Console.WriteLine(arr[h]);
            }
        }
        static void Main(string[] args)
        {
            Program p= new Program();
            int[] arr = { 1, 5, 3, 7, 8, 9, 2 };
            p.selection_sort(arr);
            Console.ReadLine();
        }
    }
}
