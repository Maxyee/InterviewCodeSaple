using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] arr = {800,11,50,771,649,770,240, 9};

            int temp = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                for(int s = 0; s < arr.Length - 1; s++)
                {
                    if(arr[s] > arr[s+1])
                    {
                        temp = arr[s+1];
                        arr[s+1] = arr[s];
                        arr[s] = temp;
                    }
                }
            }
            
            for(int z = 0; z < arr.Length;z++)
            {
                Console.WriteLine(arr[z] + " ");
            }

            Console.ReadKey();
        }  
    }
}