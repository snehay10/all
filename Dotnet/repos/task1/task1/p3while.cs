using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class p3while
    {
        public void show()
        {
            int n = 5;
            int star = n +1;
            int i = 0;
            while (i < n)
            {
                int j = 0;
                star = n - i;
                while (j < star)
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
