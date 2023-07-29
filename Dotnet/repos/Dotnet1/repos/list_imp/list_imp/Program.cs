using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_imp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var  name = new List<string>();
            name.Add("Sneha");
            name.Add("Sai");
            name.Add("Jui");
            name.Add("Jeevan");

            foreach ( var item in name)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("SortedLis \n");
            SortedList<int, String> nm = new SortedList<int, string>();
            nm.Add(1, "sneha");
            nm.Add(2, "sai");
            nm.Add(3, "jui");
            nm.Add(4, "jeevan");
            nm.Add(5, "punam");


            for(int i=0;i<nm.Count;i++)
            {
                Console.WriteLine(nm.Keys[i]+" = " + nm.Values[i]);
            }


            Console.WriteLine("\n\n\nstack ......");
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            foreach (var item in myStack)
            {
                Console.Write(item + ",");
            }


            Console.WriteLine("\n\n Queue......");
            Queue<int> q= new Queue<int>();
            q.Enqueue(11);
            q.Enqueue(12);
            q.Enqueue(13);
            q.Enqueue(14);
            q.Enqueue(15);

            foreach (var item in q)
            {
                Console.WriteLine(item + ",");
            }

            Console.WriteLine("dequeue elements ="+q.Dequeue());
            Console.WriteLine("peeked elements =" + q.Peek());
            Console.WriteLine("Contains method =" + q.Contains(13));

            Console.ReadLine();



        }
    }
}
