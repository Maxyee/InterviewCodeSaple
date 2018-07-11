using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loops
{
    class Loops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping From 1 to 10 then 10 to 1");

            for(int i = 1; i<=10 ;i++)
            {
                Console.WriteLine(i);

                if(i == 10)
                {
                    for(int j = 10; j>=1; j--)
                    {
                        Console.WriteLine(j);
                    }
                }
            }

            Console.ReadKey();
        }  
    }
}