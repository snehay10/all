using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_2_pat
{
    internal class Program
    {

        public int star;
        public int space;
        public int n;


        public void p1()
        {
            Console.WriteLine("Enter number of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                star = i+1;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void p2()
        {
            Console.WriteLine("Enter number of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                space = n - i - 1;
                for(int k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }
                star = i + 1;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void p3()
        {
            Console.WriteLine("Enter number of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                star = n-i;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void p4()
        {
            Console.WriteLine("Enter number of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                space = i;
                for (int k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }
                star =n-i;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void p5()
        {
            Console.WriteLine("Enter number of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                space = n -i;
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                star = i*2-1;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void p6()
        {
            Console.WriteLine("Enter number of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                space = i;
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                star = ((n*2)-(i*2))-1;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }



        public void p7()
        {
            Console.WriteLine("Enter number of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                space = n - i;
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                star = i * 2 + 1;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int i = 1; i < n; i++)
            { 
                space = i+1;
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }

                star = ((n * 2) - (i * 2)) - 1;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void p8()
        {
            Console.WriteLine("Enter number of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                star = i + 1;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i < n; i++)
            {
                star = n - i;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void p9()
        {
            Console.WriteLine("Enter number of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                space = n - i - 1;
                for (int k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }
                star = i + 1;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i < n; i++)
            {

                space = i;
                for (int k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }
                star = n - i;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void p10()
        {
            Console.WriteLine("Enter number of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                space = n - i - 1;
                for (int k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }
                star = n;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void p11()
        {
            Console.WriteLine("Enter number of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                space = i;
                for (int k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }
                star = n ;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void p12()
        {
            Console.WriteLine("Enter number of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                star = n - i;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i < n; i++)
            {
                star = i + 1;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void p13()
        {
            Console.WriteLine("Enter number of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                space = i;
                for (int k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }
                star = n - i;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            for (int i = 1; i < n; i++)
            {

                space = n - i - 1;
                for (int k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }
                star = i + 1;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void p14()
        {
            Console.WriteLine("Enter number of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                space = i;
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                star = n-i;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i < n; i++)
            {
                space =n - i-1;
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                star = i+1;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public void p15()
        {
            Console.WriteLine("Enter number of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
               
                for(int j=0;j<n;j++)
                {
                    if (i==j || j==0 || i==n-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }


        public void p16()
        {
            Console.WriteLine("Enter number of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                space = n - i -1 ;
                for(int k=0; k< space; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < n; j++)
                {
                    if (i == j || j == 0 ||i==n-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {

            Program P= new Program();
            P.p1();
            P.p2();
            P.p3();
            P.p4();
            P.p5();
            P.p6();
            P.p7();
            P.p8();
            P.p9();
            P.p10();
            P.p11();
            P.p12();
            P.p13();
            P.p14();
            P.p15();
            P.p16();
            Console.ReadLine();
        }
    }
}
