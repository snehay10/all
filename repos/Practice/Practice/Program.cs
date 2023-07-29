using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice
{ 
    public class Program
    {
         static void Main(string[] args)
        {
            person p= new person();
            p.show1(12, 13);
            person q = new person();
            q.show1(12,45);
            person s = p;
            Console.WriteLine(p == q);
            Console.WriteLine(p.Equals(q));
            Console.WriteLine(p == s);
            Console.WriteLine(p.Equals(s));
            Console.ReadLine();
        }
        //  {
        /*helloworld h=new helloworld();
        h.hello();*/

        /* if_else f = new if_else();
         f.even_odd(); */

        // forloop.show();
        /*  Console.WriteLine("Enter number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        fact f = new fact();
        f.factorial(num);*/


        /*int a;
        Console.WriteLine("Enter 1:sunday \n 2: monday \n3:tuesday \n4:wed \n5:thur \n6:fri \n7:saturday");
        a = Convert.ToInt32(Console.ReadLine()); 
        @switch.day(a);
;
        Console.WriteLine("Enter day");
        int  day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter month");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Enter year");
        int year = Convert.ToInt32(Console.ReadLine());
        task.check(day,month,year);
        Console.ReadLine();

         Console.WriteLine("Enter value of a = ");
          int a = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter value of b = ");
          int b = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Output of call by ref : ");
          Console.WriteLine("a = " + a);
          Console.WriteLine("b = " + b);
          int sum = call_by_ref.add(ref a, b);
          Console.WriteLine(sum);
          Console.WriteLine("a = " + a);
          Console.WriteLine("b = " + b);

          Console.WriteLine("Output of call by value : ");

          Console.WriteLine("a = " + a);
          Console.WriteLine("b = " + b);
          int sum2 = call_by_ref.add2( a, b);
          Console.WriteLine(sum2);

          Console.WriteLine("a = " +a);
          Console.WriteLine("b = "+ b);
        maxarrayelement m = new maxarrayelement();
        m.maxelement();
        max_element m = new max_element();
        m.show();
        jagged_array.jagged();
        Console.ReadLine();
        constructor_this t = new constructor_this();
        constructor_this t2 = new constructor_this("Sneha", 22);
        t2.show();
        strut_Demo s = new strut_Demo();
        s.show();

        get_set s = new get_set();
        s.Name = "Jeevan";
        Console.WriteLine(s.Name);
        Console.ReadLine();

    }*/
        
    }
}
