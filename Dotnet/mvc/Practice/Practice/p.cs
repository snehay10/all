using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class p
    {
      public void show()
        {
            Console.WriteLine("enter num :");
            String num = Console.ReadLine();
            char[] str = num.ToCharArray();
            char[] str1 =new char[str.Length];
            for (int i=0; i<str.Length; i++)
            {
                Console.WriteLine(str[0]);
                Console.WriteLine(str[str.Length]);
            }
            
            
            
           
        }
    }
}
