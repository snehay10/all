using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class p2while
    {
        public void show()
        {
            int n = 5;
            int star = n;
            int i = 0;
            while (i < star)
            {
                int j = 0, k = 0;
                int space = n - i - 1;
                while (j < space)
                {
                    Console.Write(" ");
                    j++;
                }
                while (k < i)
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
