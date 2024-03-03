using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Count
    {
        static void Main(string[] args)
        {
            int[] num = new int[] {2,3,2,5,3,2,2,2,2,2,2};
            
            for (int i = 0; i < num.Length; i++)
            {
                int count = 1;
                bool isvisit = false;
                for(int k = i-1; k >= 0; k--)
                {
                    if (num[k] == num[i])
                    {
                        isvisit = true;
                        break;
                    }

                }
                if (isvisit == false)
                {
                    for(int j =i+1; j < num.Length; j++)
                    {
                        if (num[i] == num[j])
                        {
                            count++;
                        }

                    }
                    if(count > 1)
                    {
                        Console.WriteLine("number= " + num[i] +  "count=  " +count);
                    }
                    
                }
                


            }
            



        }

    }
}
