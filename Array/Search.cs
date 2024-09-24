using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Search
    {
        static void Main(string[] args)
        {
            int [] arr = { 10, 25, 6, 18, 32, 13, 12, 4 };

            Console.WriteLine("Enter a number to be search:-");
            int num = Convert.ToInt32(Console.ReadLine());
            int index = 1;

            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    index = i; 
                    break;
                }
            }
            if(index != 1)
            {
                Console.WriteLine($"The number {num} is found at index{index}") ;
            }
            else
            {
                Console.WriteLine($"THe Number {num}is not found in the array");
            }

        }
    }
}
