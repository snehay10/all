using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    internal class Program
    {
        delegate void show(int a, int b);
        public static void add(int a, int b)
        {
            Console.WriteLine("Addition : " + (a + b));
        }
        public static void mul(int a, int b)
        {
            Console.WriteLine("Multiplication :" + (a * b));
        }

        public void dis()
        {
            List<int> list1 = new List<int>();
            Console.WriteLine("Enter number of elements : ");
            int n = Convert.ToInt32(Console.ReadLine());  
            

            for(int i=0;i<n;i++)
            {
                int input=Convert.ToInt32(Console.ReadLine());
                list1.Add(input);
            }

            for(int i=0;i<n;i++)
            {
                Console.WriteLine(list1[i]);
            }




        }
        static void Main(string[] args)
        {
            show s = new show(add);
            show s2 = new show(mul);
            Program p = new Program();
            p.dis();
            s(12, 56);
            s2(89, 67);
            Console.ReadLine();

        }
    }
}
