using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class p5for
    {
        public void show()
        {
            int n = 9;
            int space1 = 0,space2=0;
            int star1 = 0,star2=0;

            for (int i=0;i<n;i++)
            {

                space1 = n - i - 1;

                for (int j=0;j<space1;j++)
                {
                    Console.Write(" ");
                }


                star1 = n;
                for(int j=1;j<star1;j=j+2) 
                {
                    Console.Write("*");
                }



                
                }












                Console.WriteLine();
            }
        }
    }

