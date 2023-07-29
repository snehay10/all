using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    public class One1
    {
        public One1()
        {
            Console.WriteLine("Super Base class Constructor ...");
        }
        public One1(int x)
        {
            Console.WriteLine($"Super Base class Parameterized constructor \nSquare of {x} : {x*x}");
        }
        public void a() 
        {
            Console.WriteLine("Super Base class method");
        }
    }
    public class One2 :One1
    {
        public One2()
        {
            Console.WriteLine($"Base class constructor");
        }
        public One2(int x): base (x)
        {
            Console.WriteLine($"Base class parameterized constructor called {x}");
        }
    }

    public class One3 :One2
    {
       
        public One3 (int x,int y): base (y)
        {
            Console.WriteLine($" Derived class value of{y}");
        }
        public  One3()
        {
            Console.WriteLine("Derived class Constructor");
        }
    }


    public class multi_level : One3
    {
        public multi_level(int x, int y) : base (x,y)
        {
            Console.WriteLine($"2nd Derived class value of{y}");
        }
        public multi_level()
        {
            Console.WriteLine("Derived class Constructor ");
        }
    }
}
