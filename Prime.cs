using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prime
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding a prime number form an array");

            int[] arr = {1,13,2,5,4,15,21};
            
            for(int i = 0; i<= arr.Length; i++)
            {
                if(arr[i] <= 1)
                {
                    Console.WriteLine("it not a prime {0}",arr[i]);
                }
                else if(arr[i] == 2)
                {
                    Console.WriteLine("It is a prime {0}",arr[i]);
                }
                else if(arr[i] % 2 == 0 || arr[i] % 3 == 0)
                {
                    Console.WriteLine("It is not a prime {0}",arr[i]);
                }
                else
                {
                    Console.WriteLine("It is a prime {0}",arr[i]);
                }
            }

            Console.ReadKey();
        }  
    }
}