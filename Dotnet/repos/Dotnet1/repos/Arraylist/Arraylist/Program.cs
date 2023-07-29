using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Arraylist
{
    public class Program
    {
     public void show(ArrayList arr)
        {
            foreach(var item in arr)
            {
                Console.WriteLine(item.ToString());
            }

        }





        public void delete(ArrayList arr,int i)
        {
            arr.RemoveAt(i);
            Console.WriteLine("ArrayList after Delete Operation :");
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }

        }


        public void adding(ArrayList arr, int i)
        {
            arr.Add(i);
            Console.WriteLine("ArrayList after adding Operation :");
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }

        }


        public void asort(ArrayList arr)
        {
            arr.Sort();
            Console.WriteLine("ArrayList after sorting Operation :");
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public void areverse(ArrayList arr)
        {
            arr.Reverse();
            Console.WriteLine("ArrayList after reverse Operation :");
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public void aclear(ArrayList arr)
        {
            arr.Clear();
            Console.WriteLine("ArrayList cleared");

        }




        public void aupdate(ArrayList arr, int i,String s)
        {

            arr[i] = s ;
            Console.WriteLine("ArrayList after Delete Operation :");
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }

        }



        static void Main(string[] args)
        {
            var arr= new ArrayList();
            Console.WriteLine("Enter Arraylist elements : ");
            arr.Add("Sneha");
            arr.Add("Suresh");
            arr.Add("yadav");
            Program p = new Program();



            Console.WriteLine("Enter your choice\n1:read\n2:update\n3:delete elements \n4:add\n5:sort\n6:reverse\n7:clear");
            int ch = Convert.ToInt32(Console.ReadLine());   
            switch(ch)
            {
                case 1: p.show(arr);
                    break;

                case 2:
                    Console.WriteLine("Enter index of  element which element u wanted to update");
                    int r = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter new value : ");
                    String s= Convert.ToString(Console.ReadLine());
                    p.aupdate(arr, r ,s);
                    break;



                case 3:Console.WriteLine("Enter index of  element which element u wanted to remove");
                    int s1 = Convert.ToInt32(Console.ReadLine());
                    p.delete(arr, s1);
                    break;

                case 4:
                    Console.WriteLine("Enter new value : ");
                    int s3 = Convert.ToInt32(Console.ReadLine());
                    p.adding(arr, s3);
                    break;
                case 5:p.asort(arr);
                    break;
                case 6:
                    p.areverse(arr);
                    break;
                case 7: p.aclear(arr);
                    break;

            }
            Console.ReadLine();
            





        }
    }
}
