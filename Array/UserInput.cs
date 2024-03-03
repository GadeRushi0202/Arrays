using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class UserInput
    {
        static void Main(string[] args)
        {
            /* int[] arr = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
             Console.WriteLine(arr[4]);//print value using index number 
             arr[5] = 500;
             Console.WriteLine(arr[5]); //update value using index number*/

            int[] arr = new int[10];
            Console.WriteLine("Enter a Number:-");
            for (int i =0; i<arr.Length; i++)
            {
                //Console.WriteLine("Enter a Number:-");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i= 0;i<arr.Length; i++)
            {
                Console.WriteLine($"Number[{i}]  =  {arr[i]}");
            }
        }
    }
}
