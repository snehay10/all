using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output of multilevel inheritance .....");
            multilevel m = new multilevel();
            m.a();
            m.b();
            m.c();
            m.d();
            Console.WriteLine();
            Console.WriteLine();

            demo1 d1 = new demo1();
            demo2 d2 = new demo2();
            Console.WriteLine("Aggregation ......");
           Aggregation ag = new Aggregation(1,"Jeevan");
            demo3 d3 = new demo3(23,ag);
            d3.show();

            Console.WriteLine("\nConstructor overloading ......");
            overloading o = new overloading();
            overloading o1 = new overloading(12);
            overloading o2 = new overloading(12,34);

            Console.WriteLine("\n\nmethod overloading ....");
           
            o.one();
            o.one("Sneha", "yadav");
            o.one(23);
            

            Console.WriteLine("\nmethod overriding ......");
            overriding ss = new overriding();
            ss.show();

           /* sealed_class2 x= new sealed_class2();
            x.stud();
            x.student();*/


            Console.ReadLine();



        }
    }
}
