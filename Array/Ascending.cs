using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Ascending
    {
        static void Main(string[] args)
        {
            // Declare an array of 5 element & sort it in ascending order.
            // bubble sort method.
            int[] arr = { 10, 5, 96, 84, 12 };
            for(int i=0; i < arr.Length; i++)
            {
                for(int j=0;j<arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach(int res in arr)
            {
                Console.WriteLine(res);
            }
        }
    }
}
