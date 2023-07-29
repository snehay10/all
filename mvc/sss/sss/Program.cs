using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sss
{
    public class Generic<T>
    {
        public T show(T a,T b)
        {
            dynamic ab = a;
            dynamic bc = b;
            dynamic r = ab+bc;
            return r;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Generic<int> k=new Generic<int>();
            int a = 10;
            int b = 10;
            Console.WriteLine(k.show(a,b));
            Console.ReadLine();

          
           
        }
    }
}
