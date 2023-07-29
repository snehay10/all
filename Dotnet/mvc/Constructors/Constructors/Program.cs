using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{


    public class one
    {
        public String x;
         static one()
        {
            Console.WriteLine("Static constructor");
        }
       public one(String a)
        {
            x = a;
            Console.WriteLine("Sneha"+x);
        }
    }

    public class Program : one
    {
        static Program() 
        {
            Console.WriteLine("Derived class constructor");
        }
        public Program(String g):base(g)
        {
            Console.WriteLine("hate");

        }
        public void show()
        {
            Console.WriteLine("yadav.......!");
        }
        static void Main(string[] args)
        {
            String g = "ssss";
            Program p= new Program(g);
            
        }
    }
}
