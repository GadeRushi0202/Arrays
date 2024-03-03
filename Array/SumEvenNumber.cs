using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class SumEvenNumber
    {
        // WAP to create int type of array and calculate sum of even  element from the array.
        static void Main(string[] args)
        {
            int sum = 0;
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach(int num in number)
            {
                if (num % 2 == 0)
                {
                    sum=sum + num;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
