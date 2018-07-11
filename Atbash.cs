using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atbash
{
    class Atbash
    {
        const string letters = "abcdefghijklmnopqrstuvwxyz";

        static void Main(string[] args)
        {
            Console.WriteLine(_Ciper("irk"));
            Console.WriteLine(_Ciper("low"));
            Console.WriteLine(_Ciper("hob"));
            Console.WriteLine(_Ciper("hold"));
            Console.ReadKey();
        }

        private static string _Ciper(string text)
        {
            string ciperedText = "";
            int index;
            foreach(var c in text)
            {
                index = letters.IndexOf(c);
                ciperedText += letters.Substring(25 - (index), 1);
            }
            return ciperedText;
        }
    }
}
