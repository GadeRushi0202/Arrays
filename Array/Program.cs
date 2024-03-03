using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*double[] day = new double[7];
            for (int i = 0; i < day.Length; i++)
            {
                day[i] = Convert.ToDouble(Console.ReadLine());

            }
              for (int i =0; i < day.Length; i++)
              {
                    Console.WriteLine($"day[{i}]= {day[i]}");
              }*/
/*
            Fibbonacci Series

             int a = 0;
             int b = 1;
             int c;
           Console.WriteLine(a);
             Console.WriteLine(b);
             for(int i = 0; i < 10; i++)
             {
                 c = a + b;
                 Console.WriteLine(c);
                 a = b;
                 b = c;
             }*/


           /* Factorail 

             Console.WriteLine("Enter A Number");
             int Num = Convert.ToInt32(Console.ReadLine());
            *//* int Num= 5;*//*
             int Fact = 1;
             for(int i=1;i<=Num; i++)
             {
                 Fact= Fact* i;
             }
             Console.WriteLine(Fact);*/

            /*Prime Number


            Console.WriteLine("Enter a Number");
            int Num = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for(int i= 2; i< Num / 2; i++)
            {
                a = 1;
                break;
            }
            if (a == 0)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not primr Number");
            }*/

           /* Write a Program print prime  number between 11 to 21
            for(int i =11; i <= 21; i++)
            {
                int a = 0;
                for(int j = 2; j<=i/2; j++)
                {
                    if (i % j == 0)
                    {
                        a = 1;
                        break;
                    }

                
                }
                if(a==0)
                {
                    Console.WriteLine(i);
                }*/

            //Array Reverse Number

            /* int res = 0;
             Console.WriteLine("Enter A Number");
             int[] arr = new int[1];
             for(int i=0;i<arr.Length; i++)
             {
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }   
             for(int i =0;i<arr.Length; i++)
             {
                 while (arr[i] != 0)
                 {
                     int rem = arr[i]%10;
                     res= (res*10) + rem;
                     arr[i] = arr[i]/10;

                 }

             }
             Console.WriteLine(res);*/

            //MAx Min Array

            /* Console.WriteLine("Enter A Number");
             int[] arr = new int[5];
             int max = arr[0];
             for(int i=0; i<arr.Length; i++)
             {
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }
             for(int i = 0; i < arr.Length; i++)
             {
                 if (arr[i] > max)
                 {
                     max= arr[i];
                 }
             }
             Console.WriteLine("Maximum Number"+max);*/

            //Min Number

            
            Console.WriteLine("Enter a Number");
            int[] arr = new int[5];
           
            for (int i = 0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            int Min = arr[0];
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] < Min)
                {
                    Min = arr[i];
                }
            }
            Console.WriteLine(Min);
        }
    }    
 }

