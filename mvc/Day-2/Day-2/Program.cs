using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    public class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Single level inheritance");
              single_level sl=new single_level();
              sl.display();
              sl.show();

              Console.WriteLine("\n\n\nMulti-level inheritance");
              multi_level ml = new multi_level(12,10);
              multi_level ml1 = new multi_level();
              ml.a();

              Console.WriteLine("\n\n\nHierarchical inheritance");
              h_two t = new h_two();


              Console.WriteLine("\n\n overriding");
              Overriding o = new Overriding();
              o.show();

              Console.WriteLine("\n\n\nMultiple inheritance inheritance");
              multiple_inheritance mi = new multiple_inheritance();
              mi.a(); 

            

        }
    }
}
