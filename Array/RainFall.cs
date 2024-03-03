using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class RainFall
    {
        
        //WAP to accept rainfall for a week from the user & display the rainfall using an array.

        static void Main(string[] args)
        {

            double[] day = new double[7];

            for(int i =0;i<day.Length;i++)
            {
                day[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Print the RainFall");

            for(int i = 0; i < day.Length;i++)
            {
                Console.WriteLine($"For Day[{i}]  = {day[i]}");
            }

        }
    }
}
