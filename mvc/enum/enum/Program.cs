using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
   public enum nm
    {
        sneha = 0,
        yadav,
        sai,
        a,
        b,
        c,
        d
    }
   abstract  public class one
    {
        public abstract void show();
        virtual public void show1()
        {
            Console.WriteLine("I am virtual method");
        }
   
    }
    public class two : one
    {
        public override void show()
        {
            Console.WriteLine("override in two");
        }
        public override void show1()
        {
            Console.WriteLine("Ia m overrided virtual method");
        }
    }
    public class three : one
    {
        public override void show()
        {
            Console.WriteLine("override in two");
        }
    }


    public class Program
    {
       
        public void show(int a,int b,out int sum,out int mul )
        {
            sum = a + b;
            mul = a * b;

        }
        static void Main(string[] args)
        {
          //  var tuple1 = (1, 23, 45, "sneha");
            nm n=new nm();

            // Create a tuple
            Tuple<int, int, String> t = new Tuple<int ,int, String>( 11111111,2,"Sneha");
            
            Console.WriteLine($"Sum :{t.Item1 + t.Item2}");
            Console.WriteLine(n);
            var a = (nm)1;
            Console.WriteLine(a);
            var b= (nm)4;
            Console.WriteLine(b);

            Program p = new Program();
            p.show(12, 23, out int s, out int m);
            Console.WriteLine($"Sum :{s} \n multiplication :{m}");

            two tw = new two();
            tw.show1();
            
        }
    }
}
