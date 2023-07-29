using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rev
{
    
    class one
    {
       
        public one()
        {
            Console.WriteLine("one constructor");
        }

        ~one()
        {

            Console.WriteLine("destructor ");
        }
       
        static void Main(string[] args)
        {
            one o= new one();
           one o1= new one();
            System.Threading.Thread.Sleep(1000);
           

            Console.ReadLine();
        }
    }
    
}
