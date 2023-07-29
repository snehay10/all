using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_com
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //product
            int price;
            String name;
            int quantity;

            //admin
            long shopid;
            String shopnm;
            String password = "Sneha@12";
            long admin_mobile;
            int id = 0;

            //customer
            int custid;
            String cust_nm;
            long cust_mobile;


            Dictionary<String, List<int>> item_list = new Dictionary<String, List<int>>();
            List<int> item = new List<int>();



            Console.WriteLine("Enter ur choice");
            Console.WriteLine("\n1:Owner\n2:new owner\n3:customer\n4:new customer");
            int person = Convert.ToInt32(Console.ReadLine());
            switch (person)
            {
                case 1:
                    Console.WriteLine("Enter Shop id :");
                    shopid = Convert.ToInt32(Console.ReadLine());  //mobile_number

                    Console.WriteLine("");

                    Console.WriteLine("Enter Password :");
                    password = Console.ReadLine();

                    break;

                case 2:
                    id = 1;
                   


                    Console.WriteLine("Enter shop name :");
                    shopnm = Console.ReadLine();
                    Console.WriteLine("Enter Mobile number");
                    admin_mobile = Convert.ToInt64(Console.ReadLine());

                    shopid=admin_mobile;
                   
                    Console.WriteLine($"Congradulation\n it ur shopid : {shopid} \n password :{password}");

                    string filePath = "C:\\Users\\Admin\\Desktop\\sneha\\Admin.txt";
                    string contentToAppend = $"{id},{shopid},{shopnm},{admin_mobile},*{password}* \n";
                   

                    File.AppendAllText(filePath, contentToAppend);
                   
                    id = id+1;

                    string cust_file = $"C:\\Users\\Admin\\Desktop\\sneha\\Admin_{admin_mobile}.txt";

                    using (FileStream fs = File.Create(cust_file))
                    {
                        
                    }

                    break;


                case 3:
                    Console.WriteLine("Enter Customer id :");
                    custid = Convert.ToInt32(Console.ReadLine());        //customer mobile
                    Console.WriteLine("Enter Password :");
                    cust_mobile = Convert.ToInt32(Console.ReadLine());
                    break;


                case 4:
                    custid = 1;
                    Console.WriteLine("Enter shop name :");
                    cust_nm = Console.ReadLine();
                    Console.WriteLine("Enter Mobile number");
                    cust_mobile = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine($"Congradulation\n it ur shopid : {1}");
                    break;

            }









        }
    }
}
