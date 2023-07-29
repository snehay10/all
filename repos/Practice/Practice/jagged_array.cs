using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class jagged_array
    {
        public static  void  jagged()
        {
            int[][] x = new int[2][];
            x[0] = new int[5] { 2, 3, 4, 5, 4 };
            x[1] = new int[3] { 4, 5, 7 };
            

            for (int i = 0;i<x.Length;i++)
            {
                for (int j = 0; j < x[i].Length;j++)
                {
                    Console.Write(x[i][j]+" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
