using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class constructor_this
    {
        String nm;
        int age;
        public constructor_this()
        {
            Console.WriteLine("this is default constructor ......");
        }
        public  constructor_this( String nm , int age )
        {
            this.nm = nm;
            this.age = age;
        }
        public void show()
        {
            Console.WriteLine("Name :" + nm + "\nAge :" + age);
        }


    }
}
