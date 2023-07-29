using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class call_by_ref
    {
        public static  int add(ref int a,int b)
        {
            return a = a + b;
        }
        public static int add2( int a, int b)
        {
            return a = a + b;
        }

    

    }
}
