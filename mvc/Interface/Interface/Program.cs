using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface Program2
    {
        void Show();
        void show1();
    }
    interface Program1
    {
        void show2();
        
    }

    class Program : Program1,Program2
    { 
       public void Show()
        {
            Console.WriteLine("show() method ...");
        }
        public void show1()
        {
            Console.WriteLine("show1 method...");
        }
        public void show2()
        {
            Console.WriteLine("show2 method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.show2();
            p.show1();
            p.Show();
            Console.ReadLine();
        }
    }
}
