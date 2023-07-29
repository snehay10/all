using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace delgateexample
{

    public  delegate void delegates1(String msg);
    public class Program
    {
        public void matrix1()
        {
            int[,] s = new int[3, 3];
            Console.WriteLine("Enter array elements :");
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    s[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write($" {s[i, j]}");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            delegates1 dt = new delegates1(show);
            delegates1 dt1 = show;
            delegates1 dt3 = (String msg) => Console.WriteLine(msg);
            dt.Invoke("Pratiksha............");
            dt("hellow");
            dt3("Sneha Yadav");

        }

        public static void show(String s)
        {
            Console.WriteLine("Wel-Come"+s);
            Program d = new Program();
            d.matrix1();
        }

       
    }


}
