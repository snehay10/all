using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pat
{
    internal class Class1
    {

        public void show()
        {
            int r = 5, space = 0, star = 0, space1 = 0, star1 = 0;
            for (int i = 0; i < r; i++)
            {
                space = r - i;
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                star = r;
                for (int k = 0; k < star; k++)
                {
                    Console.Write(".");
                }

                space1 = i * 2;
                for (int y = 0; y < space1; y++)
                {
                    Console.Write(" ");
                }
                star1 = r;
                for (int k = 0; k < star1; k++)
                {
                    Console.Write(".");
                }

                Console.WriteLine();
            }


            int star2 = 0, space2 = 0, star3 = 0, space3 = 0;
            for (int i = 0; i < r; i++)
            {
                space2 = i;
                for (int k = 0; k < space2 - 1; k++)
                {
                    Console.Write(" ");
                }
                star2 = 5;
                for (int y = 0; y < star2; y++)
                {
                    Console.Write(".");
                }
                space3 = (r - i) * 2;
                for (int k = 0; k < space3 - 1; k++)
                {
                    Console.Write(" ");
                }
                star3 = 5;
                for (int y = 0; y < star3; y++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }



        }
    }
}

        