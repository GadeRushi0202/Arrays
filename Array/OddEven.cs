using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int[] num = new int[20];
            for (int i =0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i< num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine("Even  Number:---" + num[i]);
                }
                else
                {
                    Console.WriteLine("Odd Number:--" + num[i]);
                }
            }

           /* int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] array3 = new int[5];
            for(int i  = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Enter a Number:-");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i< array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    array2[i] =  array1[i];
                }
                else
                {
                    array3[i] = array1[i];
                }

            }
            for (int i =0; i< array2.Length; i++)
            {
                if (array2[i] > 0)
                {
                    Console.WriteLine("Even Number;-"+ array2[i]);
                }
            for ( i = 0;i< array3.Length; i++)
            {
                if (array3[i] > 0)
                {
                     Console.WriteLine("Odd NUmber:---" + array3[i]);
                }
            }
            }*/
        }
    }
}
