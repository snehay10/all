using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Admin
{
    public class Program
    {


        public void admin_adding(string name, int price, int quantity, long admin_mobile)
        {
            String cust_item;

            string Admin_path = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin\\Admin_{admin_mobile}.txt";

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
                    Console.WriteLine("ITEM ADDED TO SHOP  ITEM LIST...");
                    break;

                }
            }

            cust_item = $"{name},{price},{quantity}";
            product.Add(cust_item);
            File.AppendAllLines(Admin_path, product);
            Console.WriteLine("ITEM ADDED TO SHOP  ITEM LIST...");

        }


        public void admin_update(string name, int pricenm, int quantitynm, long admin_mobile)
        {
            string Admin_path = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin\\Admin_{admin_mobile}.txt";
            List<string> lines = new List<string>();

            int count = 0;

            lines.AddRange(File.ReadAllLines(Admin_path));

            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];
                string trimmedLine = line.Trim();
                string[] currList = trimmedLine.Split(',');
                if (currList[0].Equals(name))
                {
                    string new_line = $"{name},{pricenm},{quantitynm}";
                    lines[i] = new_line;
                    count = 1;
                }
            }

            if (count == 1)
            {
                File.WriteAllLines(Admin_path, lines);
                Console.WriteLine("FILE DATA UPDATED ...");
            }
            else
            {
                Console.WriteLine($"{name} not present");
            }
        }


        public void admin_remove(String name, long admin_mobile)
        {
            string filePath = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin\\Admin_{admin_mobile}.txt";
            List<string> lines = new List<string>();

            lines.AddRange(File.ReadAllLines(filePath));
            int count = 0;

            for (int i = 0; i < lines.Count-1; i++)
            {
                string line = lines[i];
                string trimmedLine = line.Trim();
                string[] currList = trimmedLine.Split(',');
              
                if (currList[0].Equals(name))
                {
                        lines[i] = lines[i + 1];
                        count = 1;
                        i--;
                    
                }
            }
            if (count == 1)
            {
                lines.RemoveAt(lines.Count - 1); 
                File.WriteAllLines(filePath, lines);
                Console.WriteLine("FILE DATA DELETED ...");
            }
            else
            {
                Console.WriteLine($"{name} not present ");
            }

        }


        public void admin_display(long admin_mobile)
        {
            string filePath = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin\\Admin_{admin_mobile}.txt";

            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine(fileContent);

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            String ch = "y";
           
            //product
            int price;
            String name;
            int quantity;
            int act=0;


            //admin
            long shopid;
            String shopnm;
            String password = "11";
            long admin_mobile = 0;
           // int id = 0;


            Console.WriteLine("ENTER YOUR CHOICE");
            Console.WriteLine("\n1: EXISTING ADMIN\n2: NEW ADMIN");
            int person = Convert.ToInt32(Console.ReadLine());

            switch (person)
            {
                case 1:
                    Console.Write("ENTER SHOP ID : ");
                    shopid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("ENTER PASSWORD : ");
                    password = Console.ReadLine();

                    string admin_path = "C:\\Users\\Admin\\Desktop\\sneha\\Admin\\Admin.txt";

                    List<string> lines = new List<string>();
                    lines.AddRange(File.ReadAllLines(admin_path));

                    bool valid = false;

                    foreach (string line in lines)
                    {
                        string trimmedLine = line.Trim();
                        string[] currList = trimmedLine.Split(',');

                        string shopid_ = shopid.ToString();

                        if (shopid_.Equals(currList[0]) && password.Equals(currList[2]))
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
                        Console.WriteLine("Something is wrong...");
                    }

                    break;


                case 2:

                    Console.Write("ENTER SHOP NAME : ");
                    shopnm = Console.ReadLine();

                    Console.Write("ENTER MOBILE NUMBER : ");
                    admin_mobile = Convert.ToInt64(Console.ReadLine());

                    shopid = admin_mobile;

                   

                    string Admin_file = "C:\\Users\\Admin\\Desktop\\sneha\\Admin\\Admin.txt";

                    List<string> liness = new List<string>();
                    liness.AddRange(File.ReadAllLines(Admin_file));

                    bool validate = false;

                    foreach (string line in liness)
                    {
                        string trimmedLine = line.Trim();
                        string[] currList = trimmedLine.Split(',');
                        string custid_ = admin_mobile.ToString();

                        if (custid_.Equals(currList[0]))
                        {
                            validate = true;
                            break;
                        }
                    }

                    if (validate)
                    {
                        Console.WriteLine($"{admin_mobile} ALREADY REGISTERED..");
                        break;
                    }
                    else 
                    {
                        string contentToAppend1 = $"{shopid},{shopnm},{shopid},*{password}* \n";
                        File.AppendAllText(Admin_file, contentToAppend1);
                        Console.WriteLine($"\nSHOPID: {admin_mobile} \nPASSWORD: {password}");

                        string path = "C:\\Users\\Admin\\Desktop\\sneha\\Admin";
                        string new_file = Path.Combine(path, $"Admin_{admin_mobile}.txt");
                      

                        using (FileStream ac = File.Create(new_file))
                        { }

                        act = 1;
                    }
                    break;

                   default: Console.WriteLine("PLZ ENTER VALIDE INPUT ");
                      break;


            }


            if(act == 1)
            { 
                while (ch == "Y" || ch == "y")
                {
                    Console.WriteLine("\n\nENTER YOUR CHOICE \n1:ADD ITEM INTO LIST\n2:UPDATE LIST\n3:REMOVE ITEM FROM LIST\n4:VIEW LIST\n5:EXIT\n\n");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:

                            Console.Write("\nENTER NAME OF ITEM : ");
                            name = Console.ReadLine();
                            Console.Write("ENTER PRICE OF ITEM : ");
                            price = Convert.ToInt32(Console.ReadLine());
                            Console.Write("ENTER QUANTITY OF ITEM : ");
                            quantity = Convert.ToInt32(Console.ReadLine());

                            p.admin_adding(name, price, quantity, admin_mobile);

                            break;


                        case 2:
                            Console.Write("\nENTER NAME OF ITEM : ");
                            name = Console.ReadLine();
                            Console.Write("ENTER NEW PRICE OF ITEM : ");
                            int pricenm = Convert.ToInt32(Console.ReadLine());
                            Console.Write("ENTER NEW  QUANTITY OF ITEM : ");
                            int quantitynm = Convert.ToInt32(Console.ReadLine());

                            p.admin_update(name, pricenm, quantitynm, admin_mobile);
                            break;

                        case 3:
                            Console.WriteLine("\nENTER NAME OF ITEM : ");
                            name = Console.ReadLine();

                            p.admin_remove(name, admin_mobile);
                            break;

                        case 4:
                            Console.WriteLine("ITEM LIST\n");
                            p.admin_display(admin_mobile);
                            break;
                        case 5: break;
                    }

                    Console.WriteLine("\n\nDO YOU WANT TO CONTINUE...\nENTER ' Y ' IF YES ");
                    ch = Console.ReadLine();
                }
                
            }
        }
    }
}

