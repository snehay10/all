using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public interface  demo6
    {
       void show();
        void addition();
    }

    class interface_Demo : demo6
    {
        public void show()
        {
            Console.WriteLine("Abstract first method implematation........");
        }
      public   void addition()
        {
            Console.WriteLine("Abstract second method implematation........");
        }

        void demo6.show()
        {
            throw new NotImplementedException();
        }

        void demo6.addition()
        {
            throw new NotImplementedException();
        }
    }

}