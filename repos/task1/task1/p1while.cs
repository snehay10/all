using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class p1while
    {
        public void show()
        {
           int n= 5;
            int star = n;
            int i = 0;
            while (i < star)
            {
                int j = 0;

                while (j < i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }

        }
    }
}
