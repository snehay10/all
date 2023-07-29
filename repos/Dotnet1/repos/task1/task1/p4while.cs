using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class p4while
    {
        public void show()
        {
            int n = 5;
            int star = n;
            int space = 0;
            int i = 0;
            while (i < n)
            {
                int j = 0,k=0;
                space = i;
                while(j<space)
                {
                    Console.Write(" ");
                    j++;
                }
                star = n - i;
                while (k < star)
                {
                    Console.Write("*");
                    k++;
                }

                Console.WriteLine();
                i++;
            }

        }
    }
}
