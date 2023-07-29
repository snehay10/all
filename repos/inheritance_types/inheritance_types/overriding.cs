using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_types
{
    
    public class demo4
    {
        public virtual void show()
        {
            Console.WriteLine("Good .....");
        }
    }
    public class overriding : demo4
    {
        public override void show()
        {
            Console.WriteLine("Good Morning ......");
        }

    }
    

}
