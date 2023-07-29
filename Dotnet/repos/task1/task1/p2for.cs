using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class p2for
    {
        public void show()
        {
            int n = 5;
            int star = n;
            int space = 0;

            for (int i = 0; i < n; i++)
            {
                space = n - i - 1;
                for (int j=0;j < space; j++)
                {
                    Console.Write(" ");
                }
                star = i+1;

                for (int k=0;k<star;k++)
                {
                    Console.Write("*");
                }
            Console.WriteLine();

            }

        }
    }
}
