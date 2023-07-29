using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class if_else
    {
        public void even_odd()
        {
            Console.WriteLine("Enter Number : ");
            int num=Convert.ToInt32(Console.ReadLine());    
            if (num%2 == 0)
            {
                if (num > 0)
                {
                    Console.WriteLine("Number is even positive");
                }
                else
                {
                    Console.WriteLine("Number is even Negative");
                        
                }
            }
            else
            {
                if (num > 0)
                {
                    Console.WriteLine("Number is odd positive");
                }
                else
                {
                    Console.WriteLine("Number is odd Negative");

                }
            }
        }
    }
}
