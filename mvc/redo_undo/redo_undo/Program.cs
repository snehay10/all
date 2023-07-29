using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redo_undo
{
    internal class Program
    {
        public static int undo(Stack<int> stack2)
        {
            return 0;
        }

        public static int redo(Stack<int> stack2)
        {
            return undo(stack2);
        }

        public void insert(int item, Stack<int> stack, Stack<int> stack3)
        {
            stack.Push(item);


            Console.WriteLine("press 1:undo \npress 2:redo");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k == 1)
            {
                Program.redo(stack3);
            }
            else if (k == 2)
            {
                Program.undo(stack3);
            }


        }

        public void remove(Stack<int> stack, Stack<int> stack2)
        {
            int d = stack.Pop();

            stack2.Push(d);

            Console.WriteLine("press 1:undo \npress 2:redo");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k == 1)
            {
                Program.redo(stack2);
            }
            else if (k == 2)
            {
                Program.undo(stack2);
            }


        }

        public void display(Stack<int> stack)
        {

            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
        }



        // revert== undo
        // reverse== redo
        static void Main(string[] args)
        {
            Program p = new Program();
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            Stack<int> stack = new Stack<int>();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);

            Console.WriteLine("1:view\n2:delete\n3:add\n4:undo\n5:redo");
            int choice = Convert.ToInt32(stack1.Pop());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter element :");
                    int item = Convert.ToInt32(Console.ReadLine());
                    p.insert(item, stack1);
                    break;

                case 2:
                    p.remove(stack1, stack2);
                    break;
                case 3:
                    p.display(stack1);
                    break;
                case 4:
                    p.undo();
                    break;
                case 5:
                    p.redo();
                    break;

            }




        }
    }   
}
