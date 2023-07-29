using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringoperation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String nm = "   sneha  yadav   ";
            Console.WriteLine($"{nm}");
            Console.WriteLine($"{nm.TrimEnd()}");
            Console.WriteLine($"{nm.TrimStart()}");
            Console.WriteLine($"{nm.Trim()}");
           nm= nm.Replace("yadav", "Bhosale");
            Console.WriteLine($"{nm}");
            Console.WriteLine($"{nm.ToLower()}");
            Console.WriteLine($"{nm.ToUpper()}");
            Console.WriteLine($"{nm.Contains("yadav")}");
            Dbug d=new Dbug();
            d.show();
            Console.ReadLine();

        }
    }
    
}
