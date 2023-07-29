using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexses
{

    public class One
    {
        private int a, b, c, d;
       public One(int a,int b,int c,int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public object this[int index]
        {
            get 
            { 
                if(index == 0)
                {
                    return a;
                }
                else if(index == 1)
                {
                    return b;
                }
                else
                {
                    return c;
                }
      
            }
           
        }


    }




    internal class Program
    {
        static void Main(string[] args)
        {
            One o = new One(1,2,3,4);
            Console.WriteLine(o[0]);
            Console.WriteLine(o[1]);
            Console.WriteLine(o[2]);
            Console.WriteLine(o[3]);
            Console.ReadLine();

        }

        

    }
}
