using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace difference_abstract_virtual
{
    public class one
    {
        public virtual  void show()
        {
            Console.WriteLine(" show method from base class");
        }
    }
    public class virtualdemo : one
    {

        public override void show()
        {
            Console.WriteLine("show mwthod from derived class");
        }
    }


    
}
