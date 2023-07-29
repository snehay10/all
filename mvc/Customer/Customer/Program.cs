using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Customer
{
    public class Program
    {

        public void cust_adding(string name, int quantity, long cust_mobile, long Admin_mobile)
        {
            string custDirectory = $"C:\\Users\\Admin\\Desktop\\sneha\\Customer\\customer_{cust_mobile}";
            string custFilePath = Path.Combine(custDirectory, "ADD_TO_CARD.txt");
            string adminFilePath = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin\\Admin_{Admin_mobile}.txt";

            List<string> adminLines = File.ReadAllLines(adminFilePath).ToList();
            List<string> custLines = File.Exists(custFilePath) ? File.ReadAllLines(custFilePath).ToList() : new List<string>();
            List<string> product = new List<string>();

            foreach (string adminLine in adminLines)
            {
                string trimmedLine = adminLine.Trim();
                string[] currList = trimmedLine.Split(',');

                if (currList[0].Equals(name))
                {
                    int int_quantity = int.Parse(currList[2]);
                    int int_price = int.Parse(currList[1]);

                    if (quantity <= int_quantity)
                    {
                        int total = quantity * int_price;
                        string cust_item = $"{name},{quantity},{total}";
                        product.Add(cust_item);
                        break;
                    }
                }
            }

            if (product.Count > 0)
            {
                custLines.AddRange(product);
                File.WriteAllLines(custFilePath, custLines);
                Console.WriteLine("DATA ADDED TO CUSTOMER FILE...");
            }
            else
            {
                Console.WriteLine($"{name} NOT AVAILABLE in item list");
            }
        }



        public void cust_update(String name, int quantitynm, long admin_mobile, long cust_mobile)
        {


            String cust_path = $"C:\\Users\\Admin\\Desktop\\sneha\\Customer\\customer_{cust_mobile}\\ADD_TO_CARD.txt";
            String Admin_path = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin\\Admin_{admin_mobile}.txt";

            List<string> lines = new List<string>();
            List<string> cust_lines = new List<string>();
            List<string> product = new List<string>();

            int FLAG = 0;

            cust_lines.AddRange(File.ReadAllLines(cust_path));

            foreach (string line in cust_lines)
            {

                string trimmedLine = line.Trim();
                string[] currList = trimmedLine.Split(',');
          

                if (currList[0].Equals(name))
                {
                    lines.AddRange(File.ReadLines(Admin_path));
                    foreach (string line1 in lines)
                    {

                        string trimmedLine1 = line1.Trim();
                        string[] curr = trimmedLine1.Split(',');

                        int q = int.Parse(curr[2]);
                        int p = int.Parse(curr[1]);
                        if(quantitynm < q)
                        {
                            int t = quantitynm * p;
                            string st = $"{name},{quantitynm},{t}";
                            product.Add(st);
                            File.AppendAllLines(cust_path,product);
                            Console.WriteLine("updated......");
                            break;
                        }
                    }
                   
                }
                else
                {
                    Console.WriteLine(name+" not present");
                }
            }
 
        }

        public void cust_remove(String name, long mobile)
        {
            String path = $"C:\\Users\\Admin\\Desktop\\sneha\\Customer\\customer_{mobile}\\ADD_TO_CART.txt";

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

            string filePath = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin\\Admin.txt";
            // string filePath = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin.txt";
            List<string> lines = new List<string>();

            lines.AddRange(File.ReadAllLines(filePath));
            Console.WriteLine("\n\n List of shopes \n");


            // foreach (string line in lines)
            for (int k = 0; k < lines.Count; k++)
            {

                string trimmedLine = lines[k].Trim();
                string[] currList = trimmedLine.Split(',');
                String a = $"{currList[0]}   :   {currList[1]}";
                Console.WriteLine($"{a}");
            }


            Console.WriteLine("ENTER SHOP ID : ");
            long shopid_ = Convert.ToInt64(Console.ReadLine());

            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];
                string trimmedLine = line.Trim();
                string[] currList = trimmedLine.Split(',');

                long mob = long.Parse(currList[0]);

                if (shopid_ == mob)
                {
                    return mob;
                }
            }

            return 0;
        }



        public void admin_display(long admin_mobile)
        {
            string filePath = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin\\Admin_{admin_mobile}.txt";

            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine(fileContent);

        }

        public void cust_display(long mobile)
        {
            string path = $"C:\\Users\\Admin\\Desktop\\sneha\\Customer\\customer_{mobile}\\ADD_TO_CARD.txt";

            string fileContent = File.ReadAllText(path);
            Console.WriteLine(fileContent);

        }


        public void ganerate_bill(long mobile)
        {

            string add_to_cart = $"C:\\Users\\Admin\\Desktop\\sneha\\Customer\\customer_{mobile}\\ADD_TO_CARD.txt";
            string bill_history = $"C:\\Users\\Admin\\Desktop\\sneha\\Customer\\customer_{mobile}\\BILL_HISTORY.txt";
            string order_history = $"C:\\Users\\Admin\\Desktop\\sneha\\Customer\\customer_{mobile}\\ORDER_HISTORY.txt";
            string dt = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            //string new_generated_file = $"C:\\Users\\Admin\\Desktop\\sneha\\Customer\\customer_{mobile}\\{mobile}_{dt}.txt";


            List<string> lines = new List<string>();
            List<string> productS = new List<string>();

            lines.AddRange(File.ReadAllLines(add_to_cart));
            Console.WriteLine("\n\n List of shopes \n");


            int total = 0;
            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();
                string[] currList = trimmedLine.Split(',');

                int t = int.Parse(currList[2]);
                total += t;
                string productInfo = $"{currList[0]}   :   {currList[1]}  : {currList[2]}";
                productS.Add(productInfo);
                Console.WriteLine(productInfo);
            }
            Console.WriteLine($"\nTOTAL BILL: {total}");
            string totalBill = total.ToString();

            Console.Write("Are you sure to place the order? (yes/no): ");
            string input = Console.ReadLine();
            if (input.ToLower() == "yes")
            {
                File.WriteAllLines(bill_history, productS);
                File.AppendAllText(bill_history, $"TOTAL BILL: {total}");
                File.AppendAllText(bill_history, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));

                File.AppendAllText(order_history, $"TOTAL BILL: {total}");
                File.AppendAllText(order_history, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));

                string dateTimeFormat = "yyyyMMdd_HHmmss";
                string currentDateAndTime = DateTime.Now.ToString(dateTimeFormat);
                string fileName = $"C:\\Users\\Admin\\Desktop\\sneha\\Customer\\customer_{mobile}\\{currentDateAndTime}_{mobile}.txt";
                File.AppendAllLines(fileName, productS);
               
                File.WriteAllText(add_to_cart, string.Empty); 
                Console.WriteLine("Order placed successfully!");
            }
            else
            {
                Console.WriteLine("Order canceled.");
            }
        }

        public void  view_order_history(long cust_mobile)
        {
            string path = $"C:\\Users\\Admin\\Desktop\\sneha\\Customer\\customer_{cust_mobile}\\ORDER_HISTORY.txt";
            string fileContent = File.ReadAllText(path);
            Console.WriteLine(fileContent);
        }

        public void view_bill_history(long cust_mobile)
        {
            string path = $"C:\\Users\\Admin\\Desktop\\sneha\\Customer\\customer_{cust_mobile}\\BILL_HISTORY.txt";
            string fileContent = File.ReadAllText(path);
            Console.WriteLine(fileContent);
        }



        static void Main(string[] args)
        {
            Program p = new Program();
            String ch = "y";
            //product
           
            String name;
            int quantity;

            //admin
            String password = "***";
            long admin_mobile = 0;
            

            //customer
            long custid =0;
            String cust_nm;
            long cust_mobile = 0;

            int act = 0;
          

            //  long input_mobile = 0;

            Console.WriteLine("ENTER YOUR CHOICE ");
            Console.WriteLine("\n1:EXISTING CUSTOMER \n2:NEW CUSTOMER");
            int person = Convert.ToInt32(Console.ReadLine());

            switch (person)
            {
                case 1:
                    Console.WriteLine("ENTER CUSTOMER ID :");
                    custid = Convert.ToInt64(Console.ReadLine());        //customer mobile

                    Console.WriteLine("ENTER PASSWORD :");
                    password = Console.ReadLine();

                    cust_mobile = custid;
                    string cust_path = "C:\\Users\\Admin\\Desktop\\sneha\\Customer\\customer.txt";

                    List<string> lines = new List<string>();
                    lines.AddRange(File.ReadAllLines(cust_path));

                    bool valid = false;

                    foreach (string line in lines)
                    {
                        string trimmedLine = line.Trim();
                        string[] currList = trimmedLine.Split(',');

                        string custid_ = custid.ToString();

                        if (custid_.Equals(currList[0]) && password.Equals(currList[2]))
                        {
                            valid = true;
                            break;
                        }
                    }

                    if (valid)
                    {
                        act = 1;
                    }
                    else
                    {
                        Console.WriteLine("SOMETHING IS WRONG ...");
                    }
                    break;




                case 2:
                  
                    Console.Write("ENTER CUSTOMER NAME  :  ");
                    cust_nm = Console.ReadLine();
                    Console.Write("ENTER CUSTOMER MOBILE NUMBER :");
                    cust_mobile = Convert.ToInt64(Console.ReadLine());

                    custid = cust_mobile;
                    string customer_file = "C:\\Users\\Admin\\Desktop\\sneha\\Customer\\customer.txt";

                    List<string> liness = new List<string>();
                    liness.AddRange(File.ReadAllLines(customer_file));

                    bool validate = false;

                    foreach (string line in liness)
                    {
                        string trimmedLine = line.Trim();
                        string[] currList = trimmedLine.Split(',');
                        string custid_ = custid.ToString();

                        if (custid_.Equals(currList[0]))
                        {
                            validate = true;
                            break;
                        }
                    }

                    if (validate)
                    {
                        Console.WriteLine($"{cust_mobile} ALREADY REGISTERED..");
                    }
                    else
                    {
                        string contentToAppend1 = $"{custid},{cust_nm},{password} \n";
                        File.AppendAllText(customer_file, contentToAppend1);

                        string folderName = $"customer_{cust_mobile}";

                        string path = @"C:\Users\Admin\Desktop\sneha\Customer";
                        string folderPath = Path.Combine(path, folderName);

                        Directory.CreateDirectory(folderPath);

                        DateTime currentdate = DateTime.Now;
                        string date = currentdate.ToString("dd-MM-yyyy");

                        string add_to_card = Path.Combine(folderPath, "ADD_TO_CARD.txt");
                        string billhistory = Path.Combine(folderPath, "BILL_HISTORY.txt");
                        string orderhistory = Path.Combine(folderPath, "ORDER_HISTORY.txt");

                        using (FileStream ac = File.Create(add_to_card))
                        { }
                        using (FileStream bh = File.Create(billhistory))
                        { }
                        using (FileStream oh = File.Create(orderhistory))
                        { }

                        Console.WriteLine($"\nCUSTID: {cust_mobile} \nPASSWORD: {password}");

                        act = 1;
                       


                    }
                        break;

                default: Console.WriteLine("PLZ ENTER VALIDE INPUT...");
                    break;

            }







           if(act ==1)
            {
                admin_mobile = p.view_admin_list();

                while (ch == "Y" || ch == "y")
                    {

                     Console.WriteLine("\n\nENTER YOUR CHOICE \n1:ADD TO CART \n2:UPDATE CART\n3:REMOVE ITEM FROM CART\n4:VIEW CART\n5:GENERATE BILL\n\n6:VIEW SHOP ITEM LIST\n\n7:VIEW ORDER HISTORY \n8:VIEW BILL HISTORY\n9:EXIT\n\n");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {

                            case 1:
                                Console.Write("\nENTER NAME OF ITEM : ");
                                 string  nameo = Console.ReadLine();
                                Console.Write("ENTER QUANTITY OF ITEM : ");
                                quantity = Convert.ToInt32(Console.ReadLine());
                                name = nameo.ToUpper(); 
                                p.cust_adding(name, quantity, cust_mobile, admin_mobile);
                                break;


                            case 2:
                                Console.Write("\nENTER NAME OF ITEM :");
                                string name1 = Console.ReadLine();
                            name= name1.ToUpper();

                                Console.Write("Enter NEW QUANTITY OF ITEM : ");
                                int quantitynm = Convert.ToInt32(Console.ReadLine());
                           
                               p.cust_update(name, quantitynm, admin_mobile, custid);
                                break;

                            case 3:
                                Console.Write("ENTER NAME OF ITEM :");
                                name = Console.ReadLine();
                                p.cust_remove(name, cust_mobile);
                                break;

                            case 4:
                                Console.WriteLine("item list");
                                p.cust_display(cust_mobile);
                                break;

                            case 5:
                                    p.ganerate_bill(cust_mobile);
                                    break;


                            case 6:
                                Console.WriteLine("item list");
                                p.admin_display(admin_mobile);
                                break;

                            case 7:p.view_order_history(cust_mobile);
                                  break;

                            case 8: p.view_bill_history(cust_mobile);
                            break;

                             case 9: break;

                        }
                        Console.WriteLine("Do u want to continue...\nenter y if yes ");
                        ch = Console.ReadLine();
                    }
                    
            }
            Console.ReadLine();
        }

    }
}
