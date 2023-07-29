using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @new
{
   abstract public   class One
    {
        public abstract void show();
    }
   public  class Two: One
    {
        public override void show()
        {
            Console.WriteLine("Sneha");
        }

        public static void main(String[] args)
        {
            Two t=new Two();
            t.show();
        }
    }

}
