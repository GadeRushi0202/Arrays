using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ReversString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string str =Console.ReadLine();
            for(int i =str.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}
