using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdcrud
{
    public  class insert1
    {
        public void show(int roll,String nm,int marks)
        {
            String ConnectionString;
            SqlConnection conn;

            ConnectionString = @"Data Source =DESKTOP-QNJIJNF\SQLEXPRESS;initial Catalog=stud;Integrated security = True";
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            
            String query5 = "INSERT INTO student (rollno,nm,marks) VALUES ('"+roll+"' , '"+nm+"' , '"+marks+"')";
            SqlCommand cmd = new SqlCommand(query5, conn);
            Console.WriteLine("Student record inserted ........");



            conn.Close();
        }
    }
}
