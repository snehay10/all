using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_types
{
    public class Aggregation
    {
        public int id;
        public string name; 
        public Aggregation(int id,String name)
        {
            this.id= id;
            this.name= name;
        }
    }

    public class demo3
    {
        public int age;
        public Aggregation a;
        public  demo3(int age , Aggregation a)
        {
            this.age = age;
            this.a = a;
        }

        public void show()
        {
            Console.WriteLine("Age = "+age+"\na = ");
            Console.WriteLine("id  = " + a.id +"\nname ="+a.name);
        }
    }
}
