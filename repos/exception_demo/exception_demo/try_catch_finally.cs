using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_demo
{
    public class try_catch_finally
    {
        public void demo()
        {
            try
            {
                int[] a = new int[5];
                Console.WriteLine("Enter array elements : ");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(" array elements  : ");
                Console.WriteLine(a[9]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Finally Block .........");
            }
        }
    }
}
