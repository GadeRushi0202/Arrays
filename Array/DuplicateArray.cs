using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class DuplicateArray
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 3, 5, 6, 7, 4, 9, 3,2, 6, 6,5,7 };
            List<int> dubplicate = new List<int>();

            for(int i = 0; i < number.Length; i++)
            {
                for(int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] == number[j] && !dubplicate.Contains(number[i]))
                    { 
                        dubplicate.Add(number[i]);
                    }
                }
            }
            Console.WriteLine("Dublicate Number");
            foreach(int num in dubplicate)
            {
                Console.WriteLine(num +" ");
            }
            Console.WriteLine();
        }
    }
}
