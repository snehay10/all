using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class task
    {
        public static void check(int day, int  month , int year)
        {
            int c = 0;
            if (day <=31 && day >=1)
            {
                c++;
            }
            if (month <= 12 && month >= 1)
            {
                c++;
           }
            if (year <= 3000 &&  year >=1000)
            {
                c++;
            }
           
            if(c ==3)
            {
                Console.WriteLine("valide date");
            }
            else
            {
                Console.WriteLine("Invalide date");
            }
            Console.WriteLine("date is  : "+day+"-"+month+"-"+year);
        }
        


    }
}
