using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace difference_abstract_virtual
{
    public class pattern_matching
    {
        String maybe = "sneha";
        public void show()
        {
            if (maybe is String)
            {
                Console.WriteLine($"{maybe} is a String");
            }
            else
            {
                Console.WriteLine($"{maybe} is not a String");
            }

                
        }
    }
}
