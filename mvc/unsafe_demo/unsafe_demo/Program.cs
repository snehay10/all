using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unsafe_demo
{

   
        class Program
        {
            static unsafe void Main(string[] args)
            {
                int var = 20;
                int* p = &var;

                Console.WriteLine("Data is: {0} ", var);
                Console.WriteLine("Address is: {0}", (int)p);
                Console.ReadKey();
            }
        }
    }

