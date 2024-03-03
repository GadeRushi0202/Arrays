using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Array
{
    internal class MaxMin
    {
        static void Main(string[] args)
        {

            //Maximum Number
            /*int[] arr = new int[5];
            Console.WriteLine("Enter a Numbner");
            int max = arr[0];

            for (int i =0;i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < arr.Length; i++){
                if (arr[i] > max)
                {
                    max= arr[i];
                    
                }
               
            }
            Console.WriteLine("Maxiumum Number:- "+max);*/

            //minimum Number

            int[] arr = new int[5];
            Console.WriteLine("Enter a Number");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
           int Min = arr[0];
            for(int i = 0; i <arr.Length; i++)
            {
                if (arr[i] < Min)
                {
                    Min= arr[i];
                }
            }
            Console.WriteLine("Mininum Number  "+Min);
        }
    }
}
