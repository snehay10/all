using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class base1
    {

       public  void show()
        {
            Console.WriteLine("It is base class method");
        }

    }


    public class child : base1
    { 
         public void show1()
        {
            Console.WriteLine("It is derived class method");
        }
    
    }





    public class inheritance 
    {
        public static void main(string[] args)
        {
            child ch = new child();
            ch.show1();
            ch.show();

        }
    }



}
