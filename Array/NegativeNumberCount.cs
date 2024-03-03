using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    //  WAP to print all negative elements in an array and also count the total number of negative elements in an array.
    internal class NegativeNumberCount
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] number = new int[10];
            Console.WriteLine("Enter a Number");

            for(int i =0; i < number.Length; i++)
            {
                number[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i =0; i < number.Length;i++)
            {
                if (number[i] < 0)
                {
                    Console.WriteLine("Negative Number" + number[i]);
                    count++;
                }
            }
            Console.WriteLine("Total negative Number:- "+count);
        }
    }
}
