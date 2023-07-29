using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sneha
{
   abstract public class one
    {
        abstract public void show();
        public void hide()
        {
            Console.WriteLine("aaaaaa");
        }

    }
    public class Program : one
    {
        public override void show()
        {
            Console.WriteLine("ssss");
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.show();
            p.hide();
        }
    }
}
