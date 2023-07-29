using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Program
    {
        const int N = 5;
        int[] stack = new int[N];
        int top = -1;

        public void push(int x)
        {
            Console.WriteLine("Enter data :");
            int data = Convert.ToInt32(Console.ReadLine()); 
            if ( top == N-1)
            {
                Console.WriteLine("Stack overflow...");
            }
            else
            {
                top = top + 1;
                stack[top] = x;
            }
        }


        public void Pop()
        {
            int item;
            if (top == -1)
            {
                Console.WriteLine("underflow condition ......");
            }
            else
            {
                item = stack[top];
                top = top - 1;
                Console.WriteLine($"Poped item {item}");
            }
        }

        public void Peek()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack is empty...");
            }
            else
            {
                Console.WriteLine(stack[top]);
            }
        }

        public void Display()
        {
            int i;
            for(i=top;i>=0;i++ )
            {
                Console.WriteLine(stack[i]);
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();

           p.push(3);
            p.push(31);
            p.push(32);

            p.Pop();

           p.Peek();

           p.Display();
           Console.ReadLine();

        }
    }
}
