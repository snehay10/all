using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.Remoting.Services;
using System.Xml.Linq;

namespace ecommysql
{
    public class Program
    {
        static string query;
        static string productName;
        static string productQuantity;
        static int pid;
        static int productPrice;
        static string  connectionString = "Data Source=DESKTOP-QNJIJNF\\SQLEXPRESS;Initial Catalog=ecom;Integrated Security=True";
        public void custAddItems()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("enter product id :");
                    pid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter product id :");
                    int productQuantity = Convert.ToInt32(Console.ReadLine());
                    string subquery = "SELECT productQuantity FROM products WHERE ProductID = @productId";
                    
                    SqlCommand cmd = new SqlCommand(subquery, conn);
                    cmd.Parameters.AddWithValue("@productId", pid);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("productId"));
                        if (productQuantity<id)
                        {
                            query = "INSERT INTO addToCart(productId) values (@productId)";
                            SqlCommand cmd2 = new SqlCommand(query, conn);
                            cmd2.Parameters.AddWithValue("@productId", pid);
                            cmd2.ExecuteNonQuery();
                            Console.WriteLine("item Added to add to cart  ");

                        }
                        else
                        {
                            Console.WriteLine("quantity of that much is not available");
                        }
                    }
                        
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void custDeleteItems() 
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("enter product id :");
                    pid = Convert.ToInt32(Console.ReadLine());
                    query = "DELECT  FROM addToCart WHERE productId = @productId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@productId", pid);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("item DELETED FROM add to cart  ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void custUpdateItems() 
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("enter product id :");
                    pid = Convert.ToInt32(Console.ReadLine());
                    query = "UPDATE INTO addToCart SET productId) values (@productId)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@productId", pid);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("item Added to add to cart  ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
         public void custViewItems()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // string query="INSERT INTO "
            }

        }


        public void ownerAddItems()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("ENTER PRODUCT NAME : ");
                    productName = Console.ReadLine();
                    Console.WriteLine("ENETR PRODUCT QUANTITY : ");
                    productQuantity = Console.ReadLine();
                    Console.WriteLine("ENTER PRODUCT PRICE : ");
                    productPrice =Convert.ToInt32( Console.ReadLine());
                    query = "INSERT INTO  products(productName,productPrice,productQuantity) VALUES (@productName,@productPrice,@productQuantity)";  //@PRODUCTnAME THIS ARE VALUE PLACE HOLDER
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@productName", productName);
                    cmd.Parameters.AddWithValue("@productQuantity", productQuantity);
                    cmd.Parameters.AddWithValue("@productPrice", productPrice);



                    cmd.ExecuteNonQuery();
                    Console.WriteLine("ITEM ADDED SUCCESSFULLY");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("occured error : "+ ex.Message);
            }

        }



        public void ownerDeleteItems()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    Console.WriteLine("enter product name : ");
                    productName = Console.ReadLine();
                    conn.Open();
                    query = "DELETE FROM products where  productName = @productName ";

                    SqlCommand cmd= new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@productName", productName);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("ITEM DELETED");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("error occured :"+ex.Message);
            }

        }

        public void ownerUpdateItems()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    Console.WriteLine("enter product name : ");
                    productName = Console.ReadLine();
                    Console.WriteLine("ENTER NEW PRICE : ");
                    productPrice=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ENTER NEW QUANTITY :");
                    productQuantity = Console.ReadLine();
                    conn.Open();
                    query = "UPDATE  products SET productPrice =@productPrice ,productQuantity= @productQuantity where  productName = @productName ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@productName", productName);
                    cmd.Parameters.AddWithValue("@productPrice", productPrice);
                    cmd.Parameters.AddWithValue("@productQuantity", productQuantity);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("ITEM updated");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error occured :" + ex.Message);
            }

        }
        public void ownerViewItems()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    Console.WriteLine("Entire table data : ");
                    conn.Open();
                    query = "SELECT * FROM products";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("productId"));
                        string pname = reader.GetString(reader.GetOrdinal("productName"));
                        decimal price = reader.GetDecimal(reader.GetOrdinal("productPrice"));
                        int quantity = reader.GetInt32(reader.GetOrdinal("productQuantity"));
                        Console.WriteLine($"{id},{pname},{price},{quantity}");
                    }
                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error occured :" + ex.Message);
            }

        }

        public static void Main(String[] args)
        {
            Program p= new Program();

            Console.WriteLine("Enter Your choice \n2:New Customer \n1:New owner");
            int choice= Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1: Console.WriteLine("Enter Your choice \n1:Add items\n2:view items\n3:update items\n4:delete items ");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        switch(ch)
                    {
                        case 1:p.ownerAddItems();
                            break;
                        case 2: p.ownerViewItems();
                             break;
                        case 3:p.ownerUpdateItems();
                            break;
                        case 4: p.ownerDeleteItems();
                            break;
                        default: Console.WriteLine("Invalide input");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter Your choice \n1:Add items\n2:view items\n3:update items\n4:delete items\n5:view item list  ");
                    int ch2 = Convert.ToInt32(Console.ReadLine());
                    switch (ch2)
                    {
                        case 1:
                            p.custAddItems();

                            break;
                        case 2:
                            p.custViewItems();
                            break;
                        case 3:
                            p.custUpdateItems();
                            break;
                        case 4:
                            p.custDeleteItems();
                            break;
                        case 5: p.ownerViewItems();
                            break;
                        default:
                            Console.WriteLine("Invalide input");
                            break;
                    }
                    break;
            }


            Console.ReadLine();

        }

    }
}
