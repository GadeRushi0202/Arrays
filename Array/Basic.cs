using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Basic
    {
        static void Main(string[] args)
        {
            //declaration of array for int data type 
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
            }
        }
    }
}
