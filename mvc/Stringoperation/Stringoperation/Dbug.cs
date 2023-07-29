using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringoperation
{
    internal class Dbug
    {
        public void show()
        {
            int l = 9;
            var ch = new List<int> { 0, 1 };
            for (int i = 0; i < l; i++)
            {
                var fint = ch[ch.Count - 1];
                var lint = ch[ch.Count - 2];
                Console.WriteLine(lint + fint);
            }
            
        }
    }
}
