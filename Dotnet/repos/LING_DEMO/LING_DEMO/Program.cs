using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LING_DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] age = new int[] { 12, 43, 23, 54, 76, 87, 34, 56, 76, 96, 29, 41 };
            var item = from i in age where i > 90 select i;
            foreach (var i in item)
                {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            SqlConnection conn = new SqlConnection("integrated security:true;data source=DESKTOP-QNJIJNF\\SQLEXPRESS ;initial catelog=stud");
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from student",conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "student");
            foreach (DataRow dr in ds.Tables["student"].Rows) 
            {
                Console.WriteLine("roll no :" + dr["rollno"]);
                Console.WriteLine("name  :" + dr["nm"]);
                Console.WriteLine("marks :" + dr["marks"]);
            }
            Console.ReadLine();
        }
    }
}
