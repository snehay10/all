using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_types
{
    sealed class sealed_class
    {
        public void student()
        {
            Console.WriteLine("Sealed class method ............");
        }
    }
    
    public class sealed_class2 : sealed_class
    {
        public void stud()
        {
            Console.WriteLine("devored class method....");
        }
    }
}
