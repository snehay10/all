using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    public class Over
    {
        public void show()
        {
            Console.WriteLine("Base class method ");
        }
    }
    public class Overriding: Over
    {

        public void show()
        {
            Console.WriteLine("Derived class method");
        }
    }
}
