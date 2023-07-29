using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{

    delegate void show(int x);
    delegate void hide(int a);
    
    internal class Program
    {
        public static void add(show u, int x)          //delegate passed as parameters
        {
             x = x + 10;
            Console.WriteLine(x);
        }


        public static void pratiksha(int a)
        {
            Console.WriteLine("Sneha...."+a);
        }
       
        
        
        static void Main(string[] args)
        {

            /*  show sh = delegate (int x)
              {

                  Console.WriteLine(x * 10);
              };
              sh.Invoke(10);
              Program.add(sh, 100000);


              /*Dictionary<int,int> d= new Dictionary<int,int>();

              Console.WriteLine("Enter keys and values");
              for (int i = 1; i <= 5; i++)
              {
                int  inputkey1 = Convert.ToInt32(Console.ReadLine());
                int  inputcalue2 = Convert.ToInt32( Console.ReadLine());



                  d.Add(inputkey1, inputcalue2);

              }

              foreach (var i in d) {
                  Console.WriteLine(i.Key + ":" +  i.Value                 );

              }*/


            hide y = new hide(pratiksha);
            y(12);




        }
    }
}
