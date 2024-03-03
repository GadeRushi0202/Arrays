using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Even
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int[] num = new int[10];
            for(int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Even Number");
            for (int i = 1; i < num.Length; i++)
            {

                
                if (num[i] % 2 == 0)
                {
                    
                    Console.WriteLine(num[i]);
                }
            }
        }
    }
}
