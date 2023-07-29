using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace multithreading
{
    public class Ageexception :Exception
    {
        public Ageexception(String msg):base(msg)
        {

        } 
    }






   

    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter age :");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (age < 18)
                {
                  //  int x = 1 / 0;
                    throw new Ageexception("Invalide age");
                }
                else
                {
                    Console.WriteLine("jeevan");
                }
            }
            

            catch (Ageexception e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }






        }

        
    }
}
