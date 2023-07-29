using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    struct stud
    {
        public int id;
        public string name;
    }
    internal class strut_Demo
    {
        internal void  show()
        {
            stud s = new stud();
            s.id = 12;
            s.name = "Pritiksha";

            Console.WriteLine("Student id : "+s.id+"\nStudent name :"+s.name);
        }
    }
}
