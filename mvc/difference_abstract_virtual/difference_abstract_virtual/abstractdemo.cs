using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace difference_abstract_virtual
{
   abstract public class abstractdemo1
    {
        public abstract void show();
    }
    public class abstractdemo : abstractdemo1
    {
        public override void show()
        {
            Console.WriteLine("hello.....");
        }
    }
}
