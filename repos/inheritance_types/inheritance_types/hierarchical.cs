using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_types
{
    public class hierarchical
    {
        public hierarchical() 
        {

            Console.WriteLine("base class constructor");
        }
    }

    public class demo1 : hierarchical
    {
        public demo1()
        {
            Console.WriteLine("demo1 class constructor");
        }
    }

    public class demo2 : hierarchical
    {
        public demo2()
        {
            Console.WriteLine("demo2 class constructor ");
        }
    }


}
