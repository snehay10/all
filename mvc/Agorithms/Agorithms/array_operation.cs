using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agorithms
{
    public class array_operation
    {
        int[] arr = new int[6];
       public void show()
        {
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 4;
            arr[3] = 5;
            arr[4] = 5;
            int s = 2,v = 15;
            int temp = 0;
            for(int i=0; i<5; i++)
            {
                if(i == s)
                {
                    temp = arr[i];

                    
                }
            }

            for(int k=0;k<arr.Length;k++)
            {
                Console.WriteLine(arr[k]);
            }

        }


    }
}
