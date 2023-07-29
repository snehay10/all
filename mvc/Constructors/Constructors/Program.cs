using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
  /*  public class one
    {
        private int x;
        private String nm;
        public one(one o)    //Copy constructor

        {
            x = o.x;
            nm = o.nm;
            Console.WriteLine( x+" "+nm );
        }

        public one(int x,String nm)
        {
            this.x = x;
            this.nm = nm;
        }

    }*/
   public class one
    {
        private one(int x)
        {
            Console.WriteLine("I amprivate Constructor ");
        }
    }
    public class Program
    {
        
        static void Main(string[] args)
        {
            String g = "ssss";
          //  one o = new one(12);
            Console.ReadLine();
                
            
        }
    }
}
