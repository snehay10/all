using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_array
{
      class Program
    {
        const int N = 5;
        static int[] stack = new int[5];
        static int top = -1;

        public void pop()
        {
            if (top== -1)
            {
                Console.WriteLine("stack underflow .....");
            }
            else
            {
                Console.WriteLine($"Poped element : {stack[top]}");
                top = top - 1;
                Console.WriteLine("element poped .......");
            }
         
        }

        public void push( int x)
        {
            if (top ==N-1)
            {
                Console.WriteLine("stack overflow.....");
            }
            else
            {
                top = top + 1;
                stack[top] = x;
                Console.WriteLine("element pushed.....");
            }
        }

        public void peek()
        {
            if(top == -1)
            {
                Console.WriteLine("stack is empty..");
            }
            else
            {
                Console.WriteLine("top element :",stack[top]);
            }
        }
        public void display()
        {
            Console.WriteLine("All stack elements.......");
            {
                for(int i=0;i<=top;i++)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.push(12);
            p.push(22);
            p.push(32);
            p.push(42);
            p.push(52);
            p.pop();
            p.peek();
            p.display();
            Console.ReadLine();


        }
    }
}
