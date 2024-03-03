using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Negative
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter a Number");
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Negative Number");
            for (int i = 0; i < num.Length; i++)
            {
                
                if (num[i]<0)
                {
                    
                    Console.WriteLine($"num[{i}]= {num[i]}");
                    count++;

                }
                

            }
            Console.WriteLine("Count Number" + count);
        }
    }
}
