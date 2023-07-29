using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace task_txt
{
    public class Program
    {

        public void admin_adding(string name,int price,int quantity, long admin_mobile)
        {
            String cust_item;

            string Admin_path = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin_{admin_mobile}.txt";

            List<string> lines = new List<string>();
            List<string> product = new List<string>();

            lines.AddRange(File.ReadAllLines(Admin_path));

            foreach (string line in lines)
            {
                
                string trimmedLine = line.Trim();
                string[] currList = trimmedLine.Split(',');
                if (currList[0].Equals(name))
                {
                    cust_item = $"{price},{quantity}";
                    product.Add(cust_item);
                    File.AppendAllLines(Admin_path, product);
                    Console.WriteLine("DATA ADDED TO CUSTOMER FILE...");
                    break;

                }
                else
                {
                    cust_item = $"{name},{price},{quantity}";
                    product.Add(cust_item);
                    File.AppendAllLines(Admin_path, product);
                    Console.WriteLine("DATA ADDED TO CUSTOMER FILE...");
                    break;
                }
            }
        }




        public void cust_adding( string name, int quantity, long cust_mobile,long Admin_mobile)
        {
           
            String cust_path = $"C:\\Users\\Admin\\Desktop\\sneha\\customer_{cust_mobile}.txt";
            String Admin_path = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin_{Admin_mobile}.txt";

            List<string> lines = new List<string>();
            List<string> cust_lines = new List<string>();
            List<string> product = new List<string>();
          

            lines.AddRange(File.ReadAllLines(Admin_path));

            foreach (string line in lines)
            {
               
                string trimmedLine = line.Trim();
                string[] currList = trimmedLine.Split(',');  
                    if (currList[0].Equals(name) )
                    {
                        
                        int int_quantity = int.Parse(currList[2]);
                        int int_price = int.Parse(currList[1]);
                         
                    if (quantity < int_quantity)
                        {
                            int total = quantity * int_price;
                            String cust_item = $"{name},{quantity},{total}";


                             lines.AddRange(File.ReadAllLines(cust_path));

                            foreach (string cust_line in cust_lines)
                            {

                                string trimmedLine1 = line.Trim();
                                string[] currList_old = trimmedLine.Split(',');
                                if (currList[0].Equals(name))
                                {
                                    cust_item = $"{quantity}";
                                    product.Add(cust_item);
                                    File.AppendAllLines(cust_path, product);
      
                                    break;

                                }
                                else
                                {
                                    cust_item = $"{name},{quantity}";
                                    product.Add(cust_item);
                                    File.AppendAllLines(cust_path, product);
                                    break;
                                }
                            }
                       
                        }
                    }
            }

            if (product.Count > 0)
            {

                Console.WriteLine("DATA ADDED TO CUSTOMER FILE...");
            }
            else
            {
                Console.WriteLine($"{name} not Present ");
            }

        }





        public void admin_display(long admin_mobile) 
        {
            string filePath = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin_{admin_mobile}.txt";

            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine(fileContent);

        }





        public void cust_display(long mobile)
        {
            string path = $"C:\\Users\\Admin\\Desktop\\sneha\\customer_{mobile}.txt";

            string fileContent = File.ReadAllText(path);
            Console.WriteLine(fileContent);

        }




        public void admin_update( String name,int pricenm, int quantitynm,long admin_mobile)
        {
            string filePath = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin_{admin_mobile}.txt";
            List<string> lines = new List<string>();

            lines.AddRange(File.ReadAllLines(filePath));
            int count = 0;

            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];
                string trimmedLine = line.Trim();
               
                int word = trimmedLine.IndexOf(',');
                if(word != -1)
                {
                    String fword = trimmedLine.Substring(0, word).Trim();
                    if(fword == name)
                    {
                        String nline = $"{quantitynm},{pricenm}";
                        lines[i] = nline;
                        count = 2;
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not available");
                    }
                }
            }
            if (count == 2)
            {
                File.WriteAllLines(filePath, lines);
                Console.WriteLine("FILE UPDATED...");
            }
            else
            {
                Console.WriteLine($"{name} ");
            }


        }


        public void cust_update(String name, int quantitynm,long cust_mobile, long admin_mobile)
        {
            String path = $"C:\\Users\\Admin\\Desktop\\sneha\\customer_{cust_mobile}.txt";
            string filePath = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin_{admin_mobile}.txt";


            List<string> lines = new List<string>();
            List<string> product = new List<string>();

            lines.AddRange(File.ReadAllLines(filePath));

            foreach (string line in lines)
            {

                string trimmedLine = line.Trim();
                string[] currList = trimmedLine.Split(',');
                if (currList[0].Equals(name))
                {

                    int int_quantity = int.Parse(currList[2]);
                    int int_price = int.Parse(currList[1]);

                    if (quantitynm < int_quantity)
                    {
                        int total = quantitynm * int_price;

                        String cust_item = $"{name},{quantitynm},{total}";
                        product.Add(cust_item);
                    }


                }

            }

            if (product.Count > 2)
            {
                File.WriteAllLines(path, lines);
                Console.WriteLine("FILE UPDATED...");
            }
            else
            {
                Console.WriteLine($"{name} ");
            }


        }






          public void admin_remove(String name,long admin_mobile)
        {
            string filePath = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin_{admin_mobile}.txt";
            List<string> lines = new List<string>();

            lines.AddRange(File.ReadAllLines(filePath));
            int count = 0;

            for (int i = 0; i < lines.Count-1; i++)
            {
                string line = lines[i];
                string trimmedLine = line.Trim();

                int word = trimmedLine.IndexOf(',');
                if (word != -1)
                {
                    String fword = trimmedLine.Substring(0,word).Trim();
                    if (fword == name)
                    {
                     
                        lines[i] = lines[i+1];
                        count = 2;
                    }
                }
            }
            if (count == 2)
            {
                File.WriteAllLines(filePath, lines);
                Console.WriteLine("FILE DATA DELETED ...");
            }
            else
            {
                Console.WriteLine($"{name} not present ");
            }

        }







        public void cust_remove(String name,long mobile)
        {
            String path = $"C:\\Users\\Admin\\Desktop\\sneha\\customer_{mobile}.txt";
            List<string> lines = new List<string>();

            lines.AddRange(File.ReadAllLines(path));
            int count = 0;

            for (int i = 0; i < lines.Count - 1; i++)
            {
                string line = lines[i];
                string trimmedLine = line.Trim();

                int word = trimmedLine.IndexOf(',');
                if (word != -1)
                {
                    String fword = trimmedLine.Substring(0, word).Trim();
                    if (fword == name)
                    {

                        lines[i] = lines[i + 1];
                        count = 2;
                    }
                }
            }
            if (count == 2)
            {
                File.WriteAllLines(path, lines);
                Console.WriteLine("FILE DATA DELETED ...");
            }
            else
            {
                Console.WriteLine($"{name} not present ");
            }

        }


        public long view_admin_list()
        {
            string filePath = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin.txt";
            List<string> lines = new List<string>();

            lines.AddRange(File.ReadAllLines(filePath));
            Console.WriteLine("\n\n List of shopes \n");

           
           // foreach (string line in lines)
           for(int k=0;k<lines.Count; k++)
            {

                string trimmedLine = lines[k].Trim();
                string[] currList = trimmedLine.Split(',');
                String a = $"{k+1 } {currList[0]}   :   {currList[1]}";
                Console.WriteLine($"{a}");
            }
            Console.WriteLine("Enter shop Name");
            String shop=Console.ReadLine().Trim();
            long error = 0;
            for (int k = 0; k < lines.Count; k++)
            {

                string trimmedLine = lines[k].Trim();
                string[] currList = trimmedLine.Split(',');
                long mob = long.Parse(currList[0]);
               
                if(shop == currList[1])
                {
                    return mob;
                }
                
            }

            return error;
        }




        static void Main(string[] args)
        {
            Program p = new Program();
            String ch = "y";
            //product
            int price;
            String name;
            int quantity;

            //admin
            long shopid;
            String shopnm;
            String password = "Sneha@12";
            long admin_mobile = 0;
            int id = 0;

            //customer
            long custid;
            String cust_nm;
            long cust_mobile = 0;

            int act =0;

          //  long input_mobile = 0;

            Console.WriteLine("Enter ur choice");
            Console.WriteLine("\n1:Owner\n2:new owner\n3:customer\n4:new customer");
            int person = Convert.ToInt32(Console.ReadLine());
            switch (person)
            {
                case 1:
                    Console.WriteLine("Enter Shop id :");
                    shopid = Convert.ToInt32(Console.ReadLine());  //mobile_number

                    Console.WriteLine("Enter Password :");
                    password = Console.ReadLine();

                    String admin = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin.txt";

                    FileStream file = new FileStream(admin,FileMode.Append);
                    {
                        List<string> lines = new List<string>();
                        lines.AddRange(File.ReadAllLines(admin));


                        foreach (string line in lines)
                        { 
                            string trimmedLine = line.Trim();
                            string[] currList = trimmedLine.Split(',');
                            int owner_id   = int.Parse(currList[1]);
                            if (shopid == owner_id && password == currList[4])
                            {
                                act = 1;
                               
                            }
                            else
                            {
                                Console.WriteLine("something is wrong........");
                            }

                        }
                    }

                    break;


                case 2:
                    
                    Console.WriteLine("Enter shop name :");
                    shopnm = Console.ReadLine();

                    Console.WriteLine("Enter Mobile number");
                    admin_mobile = Convert.ToInt64(Console.ReadLine());
                    
                    shopid = admin_mobile;

                    Console.WriteLine($"congratulations\nshopid : {shopid} \n password :{password}");

                    string filePath = "C:\\Users\\Admin\\Desktop\\sneha\\Admin.txt";

                    string contentToAppend = $"{shopid},{shopnm},{admin_mobile},*{password}* \n";
                    File.AppendAllText(filePath, contentToAppend);

                    string admin_file = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin_{admin_mobile}.txt";
                    using (FileStream fs = File.Create(admin_file))
                    {

                        act = 1;
                       
                    }
                    string first_line = $"Name,Price,Quantity\n";
                    File.AppendAllText(admin_file, first_line);

                    break;


                case 3:
                    Console.WriteLine("Enter Customer id :");
                    custid = Convert.ToInt32(Console.ReadLine());        //customer mobile
                    Console.WriteLine("Enter Password :");
                    password =Console.ReadLine();

                    String customer = $"C:\\Users\\Admin\\Desktop\\sneha\\customer.txt";

                    FileStream cust = new FileStream(customer, FileMode.Open);
                    {
                        List<string> lines = new List<string>();
                        lines.AddRange(File.ReadAllLines(customer));


                        foreach (string line in lines)
                        {
                            string trimmedLine = line.Trim();

                            string[] currList = trimmedLine.Split(',');
                            int cust_id = int.Parse(currList[1]);

                            if (custid == cust_id && password == currList[4])
                            {
                                act = 2;
                            }
                            else
                            {
                                Console.WriteLine("something is wrong.......");
                            }

                        }
                    }
                    break;


                case 4:
                        id = 1; 
                        Console.WriteLine("Enter Customer name :");
                        cust_nm = Console.ReadLine();
                        Console.WriteLine("Enter Mobile number");
                        cust_mobile = Convert.ToInt64(Console.ReadLine());

                     //   String temp = cust_mobile.ToString();
                        
                        Console.WriteLine($"congratulations\ncustid : {cust_mobile} \n password : {password}");

                        custid = cust_mobile;

                        string customer_file = "C:\\Users\\Admin\\Desktop\\sneha\\customer.txt";

                        string contentToAppend1 = $"{id},{custid},{cust_nm},{cust_mobile},*{password}* \n";

                        File.AppendAllText(customer_file, contentToAppend1);


                        id = id + 1;


                        string cust_file2 = $"C:\\Users\\Admin\\Desktop\\sneha\\customer_{cust_mobile}.txt";
                        using (FileStream fs = File.Create(cust_file2))
                        {
                            act = 2;

                        }

                        break;

            }

           


            switch (act)
            {


                case 1:
                    while (ch == "Y" || ch == "y")
                    {
                        Console.WriteLine("\n\n(Admin)press\n1:Add item into list\n2:update list\n3:remove item from list\n4:view list\n5:exit \n\n");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:

                                Console.WriteLine("\nEnter name of item");
                                name = Console.ReadLine();
                                Console.WriteLine("Enter price of item");
                                price = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Quantity of item");
                                quantity = Convert.ToInt32(Console.ReadLine());

                                p.admin_adding(name, price, quantity, admin_mobile);

                                break;


                            case 2:
                                Console.WriteLine("\nEnter name of item");
                                name = Console.ReadLine();


                                Console.WriteLine("Enter new price of item");
                                int pricenm = Convert.ToInt32(Console.ReadLine());


                                Console.WriteLine("Enter new quantity of item");
                                int quantitynm = Convert.ToInt32(Console.ReadLine());

                                p.admin_update(name, pricenm, quantitynm,admin_mobile);
                                break;

                            case 3:
                                Console.WriteLine("Enter name of item");
                                name = Console.ReadLine();
                                p.admin_remove(name, admin_mobile);
                                break;

                            case 4:
                                Console.WriteLine("item list");
                                p.admin_display(admin_mobile);
                                break;
                            case 5: break;
                        }

                        Console.WriteLine("Do u want to continue...\nenter y if yes ");
                        ch = Console.ReadLine();
                    }
                    break;



                case 2:
                   

                    while (ch == "Y" || ch == "y")
                    {

                         admin_mobile = p.view_admin_list();

                        Console.WriteLine("\n\n(customer)press\n1:Add item into list\n2:update list\n3:remove item from list\n4:view list\n5:exit \n6:view store item list\n\n");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:

                                Console.WriteLine("\nEnter name of item");
                                name = Console.ReadLine();
                                Console.WriteLine("Enter Quantity of item");
                                quantity = Convert.ToInt32(Console.ReadLine());
                                p.cust_adding(name, quantity, cust_mobile,admin_mobile);

                                break;


                            case 2:
                                Console.WriteLine("\nEnter name of item");
                                name = Console.ReadLine();

                                Console.WriteLine("Enter new quantity of item");
                                int quantitynm = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter new price of item");
                                price = Convert.ToInt32(Console.ReadLine());

                                p.cust_update(name, quantitynm, admin_mobile, cust_mobile);
                                break;

                            case 3:
                                Console.WriteLine("Enter name of item");
                                name = Console.ReadLine();
                                p.cust_remove(name, cust_mobile);
                                break;

                            case 4:
                                Console.WriteLine("item list");
                                p.cust_display(cust_mobile);
                                break;

                            case 5: break;


                            case 6:
                                Console.WriteLine("item list");
                                p.admin_display(admin_mobile);
                                break;
                        }
                        Console.WriteLine("Do u want to continue...\nenter y if yes ");
                        ch = Console.ReadLine();
                    }
                 break;
            }
            Console.ReadLine();
        }
        
    }
}
