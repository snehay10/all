using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdcrud
{
    public class delete1
    {
        public void show(int r)
        {
            String ConnectionString;
            SqlConnection conn;

            ConnectionString = @"Data Source= DESKTOP-QNJIJNF\SQLEXPRESS;Initial Catalog=stud;Integrated security=True";
            conn=new SqlConnection(ConnectionString);
            
            conn.Open();
            String query3 = "DELETE FROM student WHERE rollno ='"+r+"'";
            SqlCommand cmd = new SqlCommand(query3, conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Student Record deleted ...........");

            conn.Close();

        }
    }
}
