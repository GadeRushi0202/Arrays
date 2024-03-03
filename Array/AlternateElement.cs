using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class AlternateElement
    {
        static void Main(string[] args)
        {
            // Display alternate elements from an array.
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            for(int i=0;i<num.Length; i+=2)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}
