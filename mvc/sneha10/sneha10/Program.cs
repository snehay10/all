using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sneha10
{
    public class one
    {
        int ab;
      

        public one( one t)
        {
            ab = t.ab;
            Console.WriteLine("ss :"+ab);
        }
        public one(int t)
        {
            this.ab = ab;
            Console.WriteLine(t);
        }
            
        public int details
        {
            get
            {
                return ab;
            }
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            one o = new one(12);
            one r = new one(o);
            Console.WriteLine("...."+o.details);
        }
    }
}
