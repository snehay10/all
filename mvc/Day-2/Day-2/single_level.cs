
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{


    public class One
    {

        public One()
        {
            
            Console.WriteLine("base class constructor");

        }
        public void show()
        {
            Console.WriteLine("base class method ");

        }

    }
    public class single_level : One
    {
        public single_level()
        {
            Console.WriteLine("Derived class constructor");
        }
        public void display()
        {
            Console.WriteLine("Derived class Method");
        }
    }
}
