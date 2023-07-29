using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{

    public class base1
    {
        public void show()
        {
            Console.WriteLine("base1 method ");
        }
    }

    public class base2
    {
        public void show()
        {
            Console.WriteLine("base2 method ");
        }
    }
    public class multiple_inheritance : base1,base2
    {
        public void a()
        {
            Console.WriteLine("method from derived class");
        }
    }
}
