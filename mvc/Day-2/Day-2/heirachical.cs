using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{

    public class heirachical
    {

        public heirachical()
        {
            Console.WriteLine("Base class Constructor ");
        }

    }

    public class h_one: heirachical
    {
        public h_one()
        {
            Console.WriteLine("1st derived class constructor called");
        }
    }

    public class h_two: heirachical
    {
       public h_two()
        {
            Console.WriteLine("2nd derived class constructor called");
        }
    }

}
