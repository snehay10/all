using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace queue_array
{
    public class Program
    {
        const int N = 5;
        static int front = -1;
        static int rear = -1;
        static int[] queue = new int[N];

        public void enqueue(int x)
        {
            if(rear == N-1)
            {
                Console.WriteLine("Queue overflow....");
            }
            else
            {
                rear = rear + 1;
                queue[rear] = x;
                Console.WriteLine("Element inserted successfully ........");
            }

        }

        public void dequeue()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue underflow.....");
            }
            else
            {
                front = front + 1;
                Console.WriteLine($" element removed : {queue[front]}");
                front = front - 1;
            }

        }
        public void peek()
        {
            if (rear == front )
            {
                Console.WriteLine("queue is empty...");
            }
            else
            {
                Console.WriteLine("peeked element :"+queue[rear]);
            }

        }


        public void display()
        {
            Console.WriteLine("queue all elements ......");
            for (int i=0; i<rear; i++)
            {
                Console.WriteLine(queue[i]);
            }

        }




        static void Main(string[] args)
        {
            Program p = new Program();
            p.enqueue(10);
            p.enqueue(11);
            p.enqueue(12);
            p.enqueue(13);
            p.enqueue(14);
            p.dequeue();
            p.peek();
            p.display();
            Console.ReadLine();

        }
    }
}
