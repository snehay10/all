using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//max element from each row in matrix and entire matrix

namespace Practice
{
    public class max_element
    {
        int[,] a = new int[3, 3];
        public void show()
        {
            Console.WriteLine("Enter 9 array elements");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("matrix ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i,j] +" ");
                }
                Console.WriteLine();
            }

            int max = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {

                    if (max < a[i, k])
                    {
                        max = a[i, k];
                    }

                }
                Console.WriteLine("maximum elements from " +i+"row : "+max);
                max = 0;

            }

            int max1 = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {

                    if (max1 < a[i, k])
                    {
                        max1 = a[i, k];
                    }

                }
              }
            Console.WriteLine("maximum element from above matrix : "+max1);

        }
    }
}
