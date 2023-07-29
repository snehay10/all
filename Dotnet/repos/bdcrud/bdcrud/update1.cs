using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdcrud
{
    public class update1
    {
        public void show(int r)
        {
            String ConnectionString;
            SqlConnection conn;

            ConnectionString = @"Data Source = DESKTOP-QNJIJNF\SQLEXPRESS; Initial Catalog = stud;Integrated security = True";
            conn= new SqlConnection(ConnectionString);


            conn.Open();

            Console.WriteLine("If You Want update student name then press : 1\nIf You want to update student marks then press : 2  ");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("Enter new name :");
                String value1 = Console.ReadLine();
                String query2 = "UPDATE student SET nm = '" + value1 +"' where rollno ='" + r +"'";
                SqlCommand cmm = new SqlCommand(query2, conn);
                cmm.ExecuteNonQuery();
                Console.WriteLine("Name Updated .......");
            }



            if (ch == 2)
            {

                Console.WriteLine("Enter new marks :");
                int value2 =Convert.ToInt32( Console.ReadLine());
                String query2 = "UPDATE student SET marks = '" + value2 + "'where rollno ='" + r +"'";
                SqlCommand cmm = new SqlCommand(query2, conn);
                cmm.ExecuteNonQuery();
                Console.WriteLine("Marks Updated .......");
            }
            conn.Close();
        }

    }
}
