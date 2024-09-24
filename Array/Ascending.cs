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
                    if (arr[i] < arr[j])                        //10<10  --> False //10<5   -->False  //10<96   -->True  //10<84   -->true //10<12 --> true

                    {
                        int temp = arr[i]; //0 0
                        arr[i] = arr[j];   //0 2
                        arr[j] = temp;     //2 10
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
