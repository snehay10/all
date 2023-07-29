using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{   ///Encapsulation 
    internal class Program
    {
        static void Main(string[] args)
        {
            Overloading o= new Overloading();
            o.add();
            o.add(56);
            o.add(8.6, 8.5);

            Calculator o1= new Calculator();
            Console.WriteLine("Substraction : \n\n");
            o1.sub(1, 1);
            o1.sub(1, 1.1);
            o1.sub(1.1, 1);
            o1.sub(1.1, 1.1);

            Calculator o2 = new Calculator();
            Console.WriteLine("Multiplication : \n\n");
            o2.mul(1, 1);
            o2.mul(1, 1.1);
            o2.mul(1.1, 1);
            o2.mul(1.1, 1.1);

            Calculator o3 = new Calculator();
            Console.WriteLine("Division : \n\n");
            o3.div(1, 1);
            o3.div(1, 1.1);
            o3.div(1.1, 1);
            o3.div(1.1, 1.1);


            Console.ReadLine();
        }
    }
}
