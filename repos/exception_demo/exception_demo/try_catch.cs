using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exception_demo
{
    public class try_catch
    {
      
        public void div(int a, int b)
        {
            try
            {
                Console.WriteLine(a / b);
            }
            catch(Exception e ) 
            {

                Console.WriteLine(e);
             }
        }   
    
    }
}
