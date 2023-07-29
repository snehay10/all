using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_types
{
    internal class overloading
    {

        public void one()
        {
            Console.WriteLine("first one method called");
        }

        public void one(String fnm ,String lnm)
        {
            Console.WriteLine("Name : "+fnm +" "+lnm);
        }
        public void one(int age) 
        {
            Console.WriteLine("Age : "+age);
        }

        public overloading(int a)
        {
            Console.WriteLine("value of a : "+a);
        }

        public overloading()
        {
            Console.WriteLine("Hello.....!");
        }

        public overloading(int a, int b)
        {
            Console.WriteLine("Addition : " + (a + b));
        }



    }

    }
