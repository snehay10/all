using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class Overloading
    {
        public void add()
        {
            Console.WriteLine("Add with no addition");
        }
        public void add(int a)
        {
            Console.WriteLine("Add method with one parameter");
        }
        /*
        public int add(int a,int b) 
        {
            Console.WriteLine($"Addition of two numbers {a + b}");
        }*/

        public void add(double a,double b)
        {
            Console.WriteLine($"Addition of two double {a+b}");
        }

    }
}
    

    




    

