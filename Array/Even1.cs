using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    //WAP to declare an array of 10 size, accept the value & print only even numbers.

    internal class Even1
    {
        static void Main(string[] args)
        {
            int[] number = new int[10];
            Console.WriteLine("Enter A Number");
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Even Number");
            for (int i =0; i < number.Length; i++)
            {
               
                if (number[i] % 2 == 0)
                {
                   // Console.WriteLine("Even Number");
                    Console.WriteLine(number[i]);
                }
            }
        }
    }
}
