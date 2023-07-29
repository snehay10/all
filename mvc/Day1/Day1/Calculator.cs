using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public  class Calculator
    {

      public void add(int a, int b)
        {
            Console.WriteLine($"Addition {a} and {b}  : {a+b}");

        }
        public void add(double a, double b)
        {
            Console.WriteLine($"Addition {a} and {b}  : {a + b}");
        }

        public void sub(int a, int b)
        {
            Console.WriteLine($"substraction {a} and {b}  : {a - b}");
        }
        public void sub(double a, double b)
        {
            Console.WriteLine($"substraction {a} and {b}  : {a - b}");
        }
        public void mul(int a, int b)
        {
            Console.WriteLine($"multiplication {a} and {b}  : {a * b}");
        }
        public void mul(double a, double b)
        {
            Console.WriteLine($"multiplication {a} and {b}  : {a * b}");
        }
        public void div(int a, int b)
        {
            Console.WriteLine($"division {a} and {b}  : {a / b}");
        }
        public void div(double a, double b)
        {
            Console.WriteLine($"division {a} and {b}  : {a / b}");
        }


        public void add(double a, int b)
        {

            Console.WriteLine($"Addition {a} and {b}  : {a + b}");
        }
        public void add(int a, double b)
        {
            Console.WriteLine($"Addition {a} and {b}  : {a + b}");
        }

        public void sub(double a, int b)
        {
            Console.WriteLine($"substraction {a} and {b}  : {a - b}");
        }
        public void sub(int a, double b)
        {
            Console.WriteLine($"substraction {a} and {b}  : {a - b}");
        }
        public void mul(double a, int b)
        {
            Console.WriteLine($"multiplication {a} and {b}  : {a * b}");
        }
        public void mul(int a, double b)
        {
            Console.WriteLine($"multiplication {a} and {b}  : {a * b}");
        }
        public void div(int a, double b)
        {
            Console.WriteLine($"division {a} and {b}  : {a / b}");
        }
        public void div(double a, int b)
        {
            Console.WriteLine($"division {a} and {b}  : {a / b}");
        }

    }

}
