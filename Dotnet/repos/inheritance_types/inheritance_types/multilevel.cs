using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_types
{

    public class one
    {
        public void a()
        {
            Console.WriteLine("base class method");
        }
    }
    public class  two : one
    {
        public void b()
        {
            Console.WriteLine("first derived class methods");

        }

    }

    public class three : two
    {
        public void c()
        {
            Console.WriteLine("second derived class methods");
        }
    }

    public class multilevel : three
    {
        public void d()
        {
            Console.WriteLine("third derived class method");
        }
    }
    
}
