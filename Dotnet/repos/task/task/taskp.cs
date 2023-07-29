using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class taskp
    {
        public void showint()
        {
            Console.WriteLine("Enter number :");
            int num = Convert.ToInt32(Console.ReadLine());

            int temp = num;
            int r, sum = 0;
            while(num> 0)
            {
                r = num % 10;
                sum=sum*10 + r;
                num = num / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("Number is palendrom ....!");
            }
            else
            {
                Console.WriteLine("Number is  not palendrom ....!");
            }
        }

        public void showstring()
        {
            Console.WriteLine("Enter String ...:");
            String nm= Console.ReadLine();
            String temp = nm;
            String st = null;
            for (int i = nm.Length-1; i >=0; i--)

            {
                st =st + nm[i];
               
            }
            if (temp == st)
            {
                Console.Write("String is pallendrom ");
            }
            else
            {
                Console.WriteLine("String is not pallendrom ...");
            }


        }
       public void sshowpalFunctio()
        {
            Console.WriteLine("Enter String ...:");
            String nm = Console.ReadLine();
            String temp = "";

            char[] t= nm.ToCharArray();
            Console.WriteLine(t);
            temp = t.Reverse().ToString();
            if (nm.Equals(temp, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        public void pat()
        {
            Console.WriteLine("Enter number of lines :");
            int r = Convert.ToInt32(Console.ReadLine());
            int star = 0, space = 0;

            for(int i=0;i<r;i++)
            {
                space =r-1-i;
                for(int j=0;j<space;j++)
                {
                    Console.Write(" ");
                }
                star = 2 * i - 1;
                for(int h=0;h<star;h++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < r; i++)
            {
                space = i+1;
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                star = r-(i*2)-1;
                for (int h = 0; h <= star; h++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            } 

        }

        public void pat2()
        {

            Console.WriteLine("Enter number of lines :");
            int r = Convert.ToInt32(Console.ReadLine());
            int star = 0, space = 0;

            for (int i = 0; i < r; i++)
            {
                space = r - 1 - i;
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                star =i + 1;
                for (int h = 0; h < star; h++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < r; i++)
            {
                space = i + 1;
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                star = r - i - 1;
                for (int h = 0; h < star; h++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        public void pat3()
        {
            Console.WriteLine("Enter number of rows");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int  i = 1; i <= n; i++)
            { 
                for(int j=1;j<=i;j++)
                {
                    if ((i==0)||(i==n-1)|| (j == i) || (j == n - 1))
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
    }
}
