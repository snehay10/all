using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class @switch
    {
        internal static void day(int n)
        {
            int d = n;
            int ch = 1;
            char choice = 'y';
            do
            {
                


                switch (d)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("friday");
                        break;
                    case 7:
                        Console.WriteLine("saturday");
                        break;
                }


                Console.WriteLine("Do u want to continue .......");
                Console.WriteLine("if yes then enter y  and enter n for no...");
                choice = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("enter n for no...");
                d = Convert.ToInt32(Console.ReadLine());

            }
            while (choice == 'y' || choice == 'Y');
          
                
            
            
        }
    }
}
