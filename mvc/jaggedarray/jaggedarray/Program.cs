using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[3] {1,2,3};
            jagged[1] = new int[5] { 1, 4, 3, 2, 3 };
            jagged[2] = new int[4] { 5, 6, 7, 8};
             
            Console.WriteLine("**** : "+jagged[1][2]);

            for(int i=0;i<3;i++)
            {
                for(int j = 0; j < jagged[i].Length; j++)
             
                {
                    Console.Write(jagged[i][j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
