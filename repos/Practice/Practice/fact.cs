using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class fact
    {

     internal void  factorial(int num)
        {
            int res= 1;
            for (int i=1;i <= num; i++)
            {
                res = res * i;
            }

        System.Console.WriteLine("Factorial of "+num+"="+res);

        }
    }
}
