using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace text_file_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String path = "C:\\Users\\Admin\\Desktop\\sneha\\as.json"; //verbatim character[" madhe ky pn asude te as string consider krt"]

            using (FileStream st = new FileStream(path, FileMode.Append,FileAccess.Write))
            {

                //String line = "Sneha yadav";
                //byte[] buffer =Encoding.UTF8.GetBytes(line);
                //st.Write(buffer, 0, line.Length);

                /*st.WriteByte(67);*/  //writing single character in txt file


                using (StreamWriter str = new StreamWriter(st))
                {
                    str.Write("Sneha");
                }
                    Console.WriteLine("File closed ............");
            }
               
            Console.ReadLine();
        }
    }
}
