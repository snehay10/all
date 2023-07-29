using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sneha
{
   
abstract public class one
    {
        abstract public  void show();
        public void hode()
        {
            Console.WriteLine("enter ");
        }
    }
public class two : one
    {
        public override void show()
        {
            Console.WriteLine("name");
        }


    }

}
