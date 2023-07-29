using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_define_exception
{


    public class invalideage : Exception
    {
        public invalideage(String msg) : base(msg)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age : ");
            int age = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if (age < 18)
                    {
                        throw new invalideage("Age is invalide");
                    }
                    else
                    {
                        Console.WriteLine("Age is valide");
                    }
                }
                catch (invalideage i)
                {
                    Console.WriteLine(i);
                }
            Console.ReadLine();
        }
    }
}
