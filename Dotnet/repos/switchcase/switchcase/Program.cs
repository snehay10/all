using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Do u want to continue .......");
            Console.WriteLine("if yes then enter y  and enter n for no...");
            choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'y' || choice == 'Y')
            {
                ch = 1;
                day(n);

            }
            else
            {
                ch = 0;
            }
        }
    }
}
