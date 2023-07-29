using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace singly_linked_list
{
    internal class Program
    {
        class Node
        {
            String data;
            Node next;
            public Node(String data) 
            {
                    this.data = data;
                    this.next = null;
            
            }
                
        }

        public void insert_first(String data)
        {
            Node node = new Node(data);
            if()

        }


        static void Main(string[] args)
        {

            Program ll = new Program();
            ll.insert_first("sneha");
        }
    }
}
