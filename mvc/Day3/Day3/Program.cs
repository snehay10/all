using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Program
    {


         static String[] item_name = new string[5] { "salt", "sugar", "oil", "atta", "abc" };
         static int[] item_price = new int[5] { 20, 40, 50, 50, 100 };

   
       

        static int[] item_list_price = new int[5] {0,0,0,0,0};
        static String[] item_list_nm=new string[5] {"","","","",""};
        static int total=0;


        void add(int i)
        {
            item_list_price[i] = item_price[i];
            item_list_nm[i] = item_name[i];
            Console.WriteLine("item added successfully");   
        }



        void update(int i)
        {
            item_list_price[i] = item_price[i];
            item_list_nm[i] = item_name[i];
            Console.WriteLine("item updated successfully");

        }



        void remove(int i)
        {
            if (item_list_price[1] == 0)
            {
                Console.WriteLine("item list is empty");
            }
            else
            {
                item_list_nm[i] ="";
                item_list_price[i] = 0;
            }
            Console.WriteLine("item deleted successfully");
        }




        void display_list()
        {
            
            for(int i=0;i<5;i++)
            {
                if (item_list_price[i] == 0)
                {
                    continue;
                }
                else 
                { 
                Console.Write($"{item_list_nm[i]} : Rs.{item_list_price[i]}\n");
                total = total + item_list_price[i];
                    Console.WriteLine($"total amount = {total}");
                }
            }
        }


        static void Main(string[] args)
        {
            Program p= new Program();
            char ch = 'y';


            Console.WriteLine("List of Grocery items");
            for (int i = 0; i < 5 ; i++)
            {
                Console.Write($"{i+1} {item_name[i]} : Rs.{item_price[i]}\n");
            }

            while (ch == 'y' || ch == 'Y')
            {
                Console.WriteLine("\n\npress\n1:Add item into list\n2:update list\n3:remove item from list\n4:view list\n5:exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                       
                        Console.WriteLine("Enter sr no if item");
                        int s = Convert.ToInt32(Console.ReadLine());
                        p.add(s - 1);
                        break;

                    case 2:
                        
                        Console.WriteLine("Enter sr no o f item to update list");
                        int up = Convert.ToInt32(Console.ReadLine());
                        p.update(up - 1);
                        break;
                    case 3:
                       
                        Console.WriteLine("Enter sr no if item");
                        int rm = Convert.ToInt32(Console.ReadLine());
                        p.remove(rm - 1);
                        break;

                    case 4: Console.WriteLine("ur item list..");
                        p.display_list();
                        break;


                    case 5: break;
                }

                Console.WriteLine("Do u want to continue...\nenter y if yes ");
                ch=Convert.ToChar(Console.Read());
            }

        }
                  
    }
}
