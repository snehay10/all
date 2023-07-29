using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace extendedmethod
{
    public class one
    {
       public void m1()
        {
            Console.WriteLine("m1 method");
        }
        public void m2()
        {
            Console.WriteLine("m2 method");
        }
        public void m3()
        {
            Console.WriteLine("m3 method");
        }
    }

  public static class  two
    {
      static  public void m4(this one o)
        {
            Console.WriteLine("m4 method");
        }
       static public void m5(this one o,int x)
        {
            Console.WriteLine($"hello {x}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            one o = new one();

            o.m1();
            o.m2();
            o.m3();
            o.m4();
            Console.WriteLine("Enter number....");
            int x = Convert.ToInt32(Console.ReadLine());
            o.m5(x);
            Console.ReadLine();

        }
    }
            
        
   
}
