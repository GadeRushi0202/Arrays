using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ReveseArray
    {
        static void Main(string[] args)
        {
            /*
            int res = 0;
            int[] arr = new int[1];
            Console.WriteLine("Enter a Number");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Revers a Number");

            for (int i = 0; i < arr.Length; i++)
            {
                while(arr[i] != 0)
                {
                    int  rem = arr[i] % 10;
                    res = (res * 10) + rem;
                    arr[i] = arr[i] / 10;
                }
                Console.WriteLine(res);
            }*/
            //Reveres Number Array
            int[] arr = new int[5];
            Console.WriteLine("Enter a Number");

            for (int i =0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Revers Number");
            for (int i = arr.Length-1; i<arr.Length; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
