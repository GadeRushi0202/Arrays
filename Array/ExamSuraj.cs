using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ExamSuraj
    {
        static void Main(string[] args)
        {
            for (int i =1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    if(i % 9 == 0)
                    {
                        Console.WriteLine("Hello");
                    }


                    else
                    {
                        Console.WriteLine("Hi");
                    }

                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
