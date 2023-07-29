

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Program p= new Program();
            p.demo();
            Console.ReadLine();
        }

        void demo()
        {
            //where demo 
            //int[] arr = new int[10] { 21,43,22,23,24,25,27,28,39,40};
            //var arresult = arr.Where(x => x % 2 == 0);
            //foreach (var x in arresult)
            //{
            //    Console.WriteLine(x);
            //}

            ////typeOf demo
            //object[] nm =  { 1,"sneha",2,"yadav",3,4,5,6,};
            //var strings = nm.OfType<string>();
            //foreach (var x in strings)
            //{
            //    Console.WriteLine(x);
            //}

            ////select many 
            //string[] phrases = { "Hello world", "I love programming", "LINQ is awesome" };
            //var words = phrases.SelectMany(phrase => phrase.Split(' '));
            //foreach (var x in words)
            //{
            //    Console.WriteLine(x);
            //}

            ////order by
            //int[] pr = { 1,2,3,4, 5,6,7,8,10};
            //var  s = pr.OrderBy(n => n);
            //foreach (var x in s)
            //{
            //    Console.WriteLine(x);
            //}
            ////OrderByDescending
            //int[] pr4 = { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            //var s4 = pr.OrderByDescending(n => n);
            //foreach (var x in s4)
            //{
            //    Console.WriteLine(x);
            //}

            ////take(2)
            //int[] pr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            //var s1 = pr.Take(5);
            //foreach (var x in s1)
            //{
            //    Console.WriteLine(x);
            //}
            ////skip(5)
            //int[] pr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            //var s2 = pr.Skip(6);
            //foreach (var x in s2)
            //{
            //    Console.WriteLine("+",x);
            //}



            int[] num = new int[] { 1, 2, 3, 23, 45, 42, 12, 14, 16,1,2,3 };
            var sr = num.GroupBy(x => x).Select(g=>$"{g.Key}{g.Count()}").Aggregate((g1,g2) => g1 + g2);
            Console.WriteLine(sr);
             string w = " ";
            string d = "";
            string c = "";
            var word = "12java12";
            StringBuilder sb = new StringBuilder();

            int[] arr = new int[word.Length - 1];
            foreach(var x in word) 
            {
               
               if(Char.IsDigit(x))
                {
                  // Console.WriteLine( x+"char"); 
                   arr.Append(x);
                }
               else
                {
                  
                    sb.Append(x);

                } 
            }
            Console.WriteLine($"{sb}  ==   {arr.ToString()}");

        }
    }
}
