// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Xml.Linq;


namespace grocery
{

    public class Program
    {
        static int main_index = 0;
        int index = 0;
        int count = 0;



        public void add(String[] main_item_name, int[] main_item_price, int[] main_item_quantity, int price, String name, int quantity)
        {
            main_item_name[main_index] = name;
            main_item_quantity[main_index] = quantity;
            main_item_price[main_index] = price;
            Console.WriteLine("Item added into Admin list  successfully");
            main_index = main_index + 1;

            
        }




        public void add(String[] main_item_name, int[] main_item_price, int[] main_item_quantity, String[] item_name, int[] item_price, int[] item_quantity,String name, int quantity)
        {

            for (int i = 0; i < main_item_name.Length; i++)
            {
                if (main_item_name[i] == name && main_item_quantity[i] == quantity)
                {
                    item_name[index] = name;
                    item_quantity[index] = quantity;
                    item_price[index] = main_item_price[i];
                    index = index + 1;
                    Console.WriteLine("Item added into Customer list  successfully");
                }

            }

        }





        public void update(String[] main_item_name, int[] main_item_price, int[] main_item_quantity, int pricenm, String name, String upnm, int quantitynm)
        {
            for (int i = 0; i < main_item_name.Length; i++)
            {
                if (main_item_name[i] == name)
                {
                    main_item_name[i] = upnm;
                    main_item_quantity[i] = quantitynm;
                    main_item_price[i] = pricenm;
                    
                }
            }
            Console.WriteLine("item updated in Admin list successfully");
        }



                                                                                


        public void update(String[] main_item_name, int[] main_item_price, int[] main_item_quantity, String[] item_name, int[] item_price, int[] item_quantity, int price, String name, String upnm, int quantity)
        {

            for (int i = 0; i < main_item_name.Length; i++)
            {

                if (item_name[i] == name)
                {
                    if (main_item_name[i] == name && main_item_price[i] == price && main_item_quantity[i] == quantity)
                    {
                        item_name[i] = name;
                        item_quantity[i] = quantity;
                        item_price[i] = price;
                    }
                }
            }
            Console.WriteLine("item in Cust list updated successfully");


        }





        public void main_remove(String[] main_item_name,int[] main_item_price, int[] main_item_quantity,String name)
        {
            int index1 = 0;
            for (int i = 0; i < main_item_name.Length; i++)
            {
                if (main_item_name[i] == name)
                {
                    index1 = i;
                }
            }
            if (index1 != 0)
            {
                for (int i = index; i < main_item_name.Length - 1; i++)
                {
                    main_item_name[i] = main_item_name[i + 1];
                    main_item_price[i] = main_item_price[i + 1];
                    main_item_quantity[i] = main_item_quantity[i + 1];
                }
            }

            Console.WriteLine("item from  admin list deleted successfully");

            main_index = main_index - 1;

        }


        public void remove(String[] item_name,int[] item_price,int[] item_quantity, String upnm1)
        {
            int index1 = 0;
            for (int i = 0; i < item_name.Length; i++)
            {
                if (item_name[i] == upnm1)
                {
                    index1 = i;
                }
            }
            if (index1 != 0)
            {
                for (int i = index; i < item_name.Length - 1; i++)
                {
                    item_name[i] = item_name[i + 1];
                    item_price[i] = item_price[i + 1];
                    item_quantity[i] = item_quantity[i + 1];
                }
            }

            Console.WriteLine("item from  admin list deleted successfully");

            index--;

        }



        public void display_list(String[] item_name, int[] item_price, int[] item_quantity)
        {
            int total = 0;
            for (int i = 0; i < index; i++)
            {
                Console.Write($"{item_name[i]} : Rs.{item_price[i]} - {item_quantity[i]} \n");
                total = total + (item_price[i] * item_quantity[i]);
            }

        }


        public void display_admin(String[] main_item_name, int[] main_item_price, int[] main_item_quantity)
        {
            
            for (int i = 0; i < main_index; i++)
            {
                Console.Write($"{main_item_name[i]} : Rs.{main_item_price[i]} - {main_item_quantity[i]} \n");
            }
           
        }








        static void Main(string[] args)
        {

            Program p = new Program();

            String ch = "y";
            Console.WriteLine("Menu ");

            String[] main_item_name = new string[10];
            int[] main_item_price = new int[10];
            int[] main_item_quantity = new int[10];

            String[] item_name = new string[10];
            int[] item_price = new int[10];
            int[] item_quantity = new int[10];

            String name;
            int price;
            int quantity;
            String upnm1;


            Console.WriteLine("if you are Admin then press 1 and if u are Customer then press 2");
            int act = Convert.ToInt32(Console.ReadLine());

            



            while (ch == "Y" || ch == "y")
            {


                if (act == 1)
                {
                    Console.WriteLine("\n\npress\n1:Add item into list\n2:update list\n3:remove item from list\n4:view list\n5:exit \n11:swtch to user site\n\n");
                }
                else if (act == 2)
                {
                    Console.WriteLine("\n\npress\n6:Add item into list\n7:update list\n8:remove item from list\n9:view list\n5:exit\n\n");
                }


                Console.WriteLine("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice==11)
                {
                    Console.WriteLine("switched to customer  : ");
                    Console.WriteLine("\n\npress\n6:Add item into list\n7:update list\n8:remove item from list\n9:view list\n5:exit\n\n");
                    act = 2;
                    choice = Convert.ToInt32(Console.ReadLine());
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter name of item");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter price of item");
                        price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Quantity of item");
                        quantity = Convert.ToInt32(Console.ReadLine());

                        p.add(main_item_name, main_item_price, main_item_quantity, price, name, quantity);
                        break;

                    case 2:

                        Console.WriteLine("\nEnter name of item");
                        name = Console.ReadLine();

                        Console.WriteLine("Enter new  name of item");
                        String upnm = Console.ReadLine();

                        Console.WriteLine("Enter new price of item");
                        int pricenm = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("Enter new quantity of item");
                        int quantitynm = Convert.ToInt32(Console.ReadLine());


                        p.update(main_item_name, main_item_price, main_item_quantity, pricenm, name, upnm, quantitynm);
                        break;


                    case 3:
                        Console.WriteLine("\nEnter name of item");
                        name = Console.ReadLine();

                        p.main_remove(main_item_name, main_item_price, main_item_quantity, name);
                        break;

                    case 4:
                        Console.WriteLine("\nAdmin item list..");
                        p.display_admin(main_item_name, main_item_price, main_item_quantity);
                        break;

                    case 6:
                        p.display_list(item_name, item_price, item_quantity);
                        Console.WriteLine("\nEnter name of item");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Quantity of item");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        p.add(main_item_name, main_item_price, main_item_quantity, item_name, item_price, item_quantity, name, quantity);
                        break;

                    case 7:
                        Console.WriteLine("Enter name of item");
                        name = Console.ReadLine();

                        Console.WriteLine("Enter new  name of item");
                         upnm1 = Console.ReadLine();

                        Console.WriteLine("Enter new price of item");
                        price = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("Enter new quantity of item");
                        quantity = Convert.ToInt32(Console.ReadLine());


                        p.update(main_item_name, main_item_price, main_item_quantity, item_name, item_price, item_quantity, price, name, upnm1, quantity);
                        break;

                    case 8:
                         Console.WriteLine("Enter new  name of item");
                         upnm1 = Console.ReadLine();

                         p.remove(item_name, item_price, item_quantity, upnm1);
                         break;
                    case 9:
                        Console.WriteLine("customer item list..");

                        p.display_list(item_name, item_price, item_quantity);
                        break;

                    case 5:
                        break;


                }


                if (choice != 5)
                {
                    Console.WriteLine("Do u want to continue...\nenter y if yes ");
                    ch = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
        }
    }
}