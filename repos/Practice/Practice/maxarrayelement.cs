using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public  class maxarrayelement
    {
        public void  maxelement()
        {
            int[] a= new int[5];
            Console.WriteLine("Enter array elements :");
            for (int i=0; i<a.Length; i++)
            {
                a[i] =Convert.ToInt32(Console.ReadLine());
            }
            int max = a[1];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
                Console.WriteLine("maximum element : " + max);
            

        }
    }
}
