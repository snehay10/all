using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace delagates
{


    public delegate void show();
    public delegate int add(int a,int b);
    public class Program
    {
        static void Main(string[] args)
        {

            Program p=new Program();
            p.s();
            show sh = new show(display);   //method with no paramethers
            
            sh();

            add a =new add(Addition); 
            //Console.WriteLine(a.s); we can't directly access varibles of method becoz it belong to only function method and function argument
            int w = a(12, 12);
            int h = a.Invoke(1,3);
         //   int y = a.Addition(7, 8);  it not allow object by using same method
            Console.WriteLine($"multiplication :{w}\nMultiplication Result by using invoke method : {h}");   // a contailn the name of method which refered by the delegates 

            Console.ReadLine();
        }

        public static int Addition(int a, int b)
        {
            
            Console.WriteLine($"Addition {a} and  {b} : {a + b}");

            return a * b;


        }

        public static void display()
        {
            int x = 12;
        Console.WriteLine("ggggggggggggggg");
            
        }




        public void s()
        {
            Console.WriteLine("enter length of array");
            int l = Convert.ToInt32(Console.ReadLine());
            int index = 0;

            int[] arr = new int[5];

            Console.WriteLine("enter 1st element of array");
            int a = Convert.ToInt32(Console.ReadLine());
            arr[index] = a;
            index = index + 1;

            Console.WriteLine("enter 2nd element of array");
            int b = Convert.ToInt32(Console.ReadLine());
            arr[index] = b;
            index = index + 1;


            Console.WriteLine("array    :\n");
            foreach(int i in arr) Console.WriteLine(i);

        }

    }
}
