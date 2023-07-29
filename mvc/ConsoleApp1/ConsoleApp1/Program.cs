using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter String :");
            String str = Console.ReadLine();
            /*swap String 
            char[] st = num.ToCharArray();
            char temp = num[0];
            st[0] = num[num.Length - 1];
            st[st.Length - 1] = temp;

            Console.WriteLine(st);
            Console.WriteLine(num[0] + num + num[0]);*/

            //char[] chars = new char[10];
            char[] st= str.ToCharArray();
            int count =0;
            char st1 = st[0];
            foreach(char c in st)
            {
              if(c == st1)
                {
                    count++;
                }
                Console.WriteLine("{0} occured : {1}", c, count);
               
            }

            Console.ReadLine();


        }
    }
}
