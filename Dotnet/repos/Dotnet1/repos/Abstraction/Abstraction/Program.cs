using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Program
    {
        public abstract void show();
        public void display()
        {
            Console.WriteLine("Non abstract method in abstract class...........");
        }
        
    }

    public class two : Program
    {
        public override void show()
        {
            Console.WriteLine("Abstract class implementation .......");
        }
    }

        public class demo
        {
            static void Main(string[] args)
            {
            two t = new two();
            t.show();
            t.display();



            Console.WriteLine("Interface implementation .......");
            interface_Demo i = new interface_Demo();
            i.show();
            i.addition();

            Console.ReadLine();
            }
        }
    
}
