using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdcrud
{
    internal class read1
    {
        public void show()
        {
            Console.WriteLine("All record from database .......");
            String ConnectString;
            SqlConnection conn;

            ConnectString = @"Data Source = DESKTOP-QNJIJNF\SQLEXPRESS; initial Catalog=stud; Integrated Security=True ";
            conn = new SqlConnection(ConnectString);

            conn.Open();


            String query1 = "select * from student";
            SqlCommand cmd=new SqlCommand(query1,conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine("Roll No : "+reader.GetValue(0).ToString());
                Console.WriteLine("Name : " + reader.GetValue(1).ToString());
                Console.WriteLine("Marks : " + reader.GetValue(2).ToString());
                Console.WriteLine("\n");

            }
            reader.Close(); 
            conn.Close();
            



        }
    }
}
