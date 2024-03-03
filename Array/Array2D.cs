using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Array2D
    {
        static void Main (string[ ] args)
        {
            //syntax 2D array 
            //here 3 is row 3 size and 4 is column size

            int[,] arr = new int[3, 4]
            {
                {10,20,30,40 },
                {50,60,70,80 },
                {90,100,110,120 }
            };
            //nested for loop to display the 2D array

            for(int row =0; row < arr.GetLength(0); row++)
            {
                for(int col =0; col < arr.GetLength(1); col++){
                    Console.WriteLine($"arr[{row} ,{col} ] = {arr[row,col]}");
                }
                Console.WriteLine("\n");
            }

        }


    }
}
