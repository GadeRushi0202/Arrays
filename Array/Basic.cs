using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Basic
    {
        static void Main(string[] args)
        {
            /*//declaration of array for int data type 
            //data type []variable name = new data type [size];
            int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //How to access single element - using index
            Console.WriteLine(num[5]);

            Console.WriteLine(num[0]);

            num[6] = 24;
            Console.WriteLine(num[6]);

            for  (int i = 1; i <= num.Length; i++)
            {
                Console.WriteLine(i);
            }*/

            /* int[] arr = new int[5];
             Console.WriteLine("Enter a Array");

             for(int i =0; i < arr.Length; i++)
             {
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }

             for(int i =0; i < arr.Length; i++)
             {
                 Console.WriteLine($"Number[{i}]  =  {arr[i]}");
             }*/
            /* int[] num = new int[5];
             Console.WriteLine("Enter a Number");

             for(int i =0; i < num.Length; i++)
             {
                 num[i] = Convert.ToInt32(Console.ReadLine());
             }
             Console.WriteLine("Even a Number");
             for (int i = 1; i < num.Length; i++)
             {
                 if (num[i] % 2 == 0)
                 {
                     Console.WriteLine(num[i]);
                 }
             }*/
            /* int[] num = new int[5];
             Console.WriteLine("Enter a Number");

             for(int i = 0; i < num.Length; i++)
             {
                 num[i]=Convert.ToInt32(Console.ReadLine());
             }
             Console.WriteLine("Even Number");
             for(int i =1; i < num.Length; i++)
             {
                 if (num[i] % 2 != 0)
                 {
                     Console.WriteLine(num[i]);
                 }
             }*/


            /*int[] arr = new int[5];
            Console.WriteLine("Enter a Number");

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Even Number");
            for(int i = 0; i< arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }*/

            //MAximun Number

            /*Console.WriteLine("Enter a Number");
            int[] num = new int[5];
            int max = num[0];

            for (int i =0; i<num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for(int i =0; i<num.Length; i++)
            {
                if (num[i] > max)
                {
                    max= num[i];    
                }
            }
            Console.WriteLine("Maximum Number = "+max);*/

            //Minimum Number

            /*Console.WriteLine("Ente a Number");
            int[] num = new int[5];
            int min = num[0];

            for(int i =0; i<num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i =0; i < num.Length; i++)
            {
                if (num[i] < min)
                {
                    min= num[i];
                }
            }*/
            /* Console.WriteLine("Enter a Number");
             int[] num = new int[5];
             int count = 0;  

             for(int i =0; i<num.Length; i++)
             {
                 num[i] = Convert.ToInt32(Console.ReadLine());
             }
             for(int i =0; i<num.Length; i++)
             {
                 if (num[i] < 0)
                 {
                     Console.WriteLine("Negaitive Number = " +num[i]);  
                    count++;    
                 }
             }
             Console.WriteLine("Total Nagative Number count = " + count);*/

            //reverse Array 

            Console.WriteLine("Enter a Number");
            int[] num = new int[5];

            for(int i =0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Revers Array");
            for(int i = num.Length-1; i< num.Length; i--)
            {
                Console.WriteLine(num[i]);
            }



        }
    }
}

