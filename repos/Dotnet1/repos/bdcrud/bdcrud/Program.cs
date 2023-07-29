using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdcrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = 'y';
            do
            {

                String ConnectString;
                SqlConnection conn;
               

                ConnectString = @"Data Source = DESKTOP-QNJIJNF\SQLEXPRESS; initial Catalog=stud; Integrated Security=True ";
                conn = new SqlConnection(ConnectString);
                conn.Open();

                Console.WriteLine("DB_CRUD Operation \nEnter Your choice\n1:View entire data\n2:Update Data\n3:delete record\n4:Insert record");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        read1 r1 = new read1();
                        r1.show();
                        break;

                    case 2:
                        update1 u1 = new update1();
                        Console.WriteLine("Enter student rollNo :");
                        int r = Convert.ToInt32(Console.ReadLine());
                        u1.show(r);
                        break;


                    case 3:
                        delete1 d = new delete1();
                        Console.WriteLine("Enter student rollno : ");
                        int rn = Convert.ToInt32(Console.ReadLine());
                        d.show(rn);
                        break;

                    case 4:
                        insert1 i = new insert1();
                        Console.WriteLine("Enter Student rollNo :");
                        int roll = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student name :");
                        String name = Console.ReadLine();
                        Console.WriteLine("Enter Student marks :");
                        int marks = Convert.ToInt32(Console.ReadLine());
                        i.show(roll, name, marks);
                        break;
                    default:
                        Console.WriteLine("Invalide Input : ");
                        break;

                }

                Console.WriteLine("Do you want to Continue.........i\nIf yes then press y\nIf No then press n");
                 ch = Convert.ToChar(Console.ReadLine());
                

                conn.Close();

            } while (ch == 'y' || ch == 'Y');
        }
    }
}
