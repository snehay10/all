using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class whileloop
    {
        internal whileloop()
        {
            Console.WriteLine("Enter Number ....");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp,sum=0,r;
            temp = num;
            while (num > 0)
            {
                r = num % 10;
                sum += (r * r * r);
                num /= 10;
            }
            if (sum == temp)
            {
                Console.WriteLine(" Number is Armstrong.....");
            }
            else
            {
                Console.WriteLine("Number is not Armstrong.....");
            }
        }
    }
}
