using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    public class Program
    {
       static int rollno;
        static string name;
        static int marks;
        static void Main(string[] args)
        {
            try
            {
                string connectionstring = @"Data Source=DESKTOP-QNJIJNF\SQLEXPRESS;Initial Catalog=stud;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                Console.WriteLine("connection done ....");

                //Console.Write("Roll No: ");
                //rollno = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Name : ");
                //name = Console.ReadLine();
                //Console.Write("Marks : ");
                //marks = Convert.ToInt32(Console.ReadLine());

                ////insert ------------------------------>

                //string insertQuery = "insert into student(rollno,nm,marks) values ('" + rollno + "','" + name + "','" + marks + "')";
                //SqlCommand insertCommand = new SqlCommand(insertQuery, conn);
                //insertCommand.ExecuteNonQuery();
                //Console.WriteLine("DATA INSERTED INTO DATABASE ......");

                //read entire data from table ----------------->

                //string displayquery = "select * from student";
                //SqlCommand displayCommand= new SqlCommand(displayquery, conn);
                //SqlDataReader reader = displayCommand.ExecuteReader();
                //while(reader.Read())
                //{
                //    Console.Write("RollNo : "+ reader["rollno"]);
                //    Console.Write("Name :" + reader["nm"]);
                //    Console.Write("marks :" + reader["marks"]); 
                //    Console.WriteLine();
                //}


                //or 

                //string displayquery = "select * from student";
                //SqlCommand cmd = new SqlCommand(displayquery, conn);
                //SqlDataReader reader = cmd.ExecuteReader();
                //while(reader.Read())
                //{
                //    Console.WriteLine($"Roll No : {reader.GetValue(0)}, Name : {reader.GetValue(1)} , Marks : {reader.GetValue(2)}");
                //}
                //Console.ReadLine();
                //reader.Close();


                //update data ----------------------------->
                Console.WriteLine("Enter name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter rollno :");
                int rollno = Convert.ToInt32(Console.ReadLine());

                // string updatequery = $"UPDATE student SET nm = {name} WHERE rollno = {rollno} ";
                //  string updatequery = $"UPDATE student SET sneha = {name} WHERE rollno = {rollno} ";



                string updatequery = $"UPDATE student SET nm = {name} WHERE rollno = {rollno}";
                SqlCommand com = new SqlCommand(updatequery,conn);
                com.ExecuteNonQuery();



                Console.WriteLine("update successfully.......");

                
                Console.ReadLine();
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

           



        }
    }
}
