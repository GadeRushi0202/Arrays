using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ForEach
    {
        static void Main(string[] args)
        {
            /*string[] name = new string[5];
             for(int i = 0 ; i < name.Length; i++)
             {
                 Console.WriteLine("enter a number");
                 name[i] = Console.ReadLine();
             }
             *//*for (int i = 0 ; i < name.Length; i++)
             {
                 Console.WriteLine(name[i]);
             }*//*
             foreach(string s in name)
             {
                 Console.WriteLine(s);
             }*/


            // second


            /*int[,] arr = new int[3, 4]
            {
                {10,20,30,40 },
                {50,60,70,80 },
                {90,100,110,120 }
            };
                        {
                foreach(int j in arr)
                {
                    Console.WriteLine(j);
                }
            }*/

            // declare an array of 5 elements and sort it in  asc order

            int[] number =  new int[5] { 45, 67, 12, 89, 5 };
           for (int i =0; i < number.Length; i++)
            {
                for (int j = 0; j<number.Length; j++)
                {
                    if (number[i] < number[j])
                    {
                        int temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;
                    }
                }
            }
            foreach (int i in number)
            {
                Console.WriteLine(i);
            }


        }
    }
}
