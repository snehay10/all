using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class p4for
    {
        public void show()
        {
            int n = 5;
            int star = 0;
            int space = 0;
            for (int i= 0; i < n; i++)
            {
                space = i;
                for(int k=0;k<space;k++)
                { Console.Write(" ");
                }
                star = n - i ;
                for (int j= 0; j < star; j++) 
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}
