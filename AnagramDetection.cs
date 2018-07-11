using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnagramDetection
{
    class AnagramDetection
    {
        static void Main(string[] args)
        {
            Console.WriteLine(_Occurences("AdnBndAndBdaBn", "dAn"));
            Console.WriteLine(_Occurences("AbrAcadAbRa", "cAda"));
            Console.ReadKey();
        }

        private static int _Occurences(string baba, string polapan)
        {
            int oocurences = 0;
            if (polapan.Length > baba.Length)
            {
                return 0;
            }

            for(int i = 0; i <= (baba.Length - polapan.Length); i++)
            {
                var babaSub = baba.Substring(i, polapan.Length);

                if (_IsAnagram(babaSub, polapan))
                {
                    oocurences++;
                }
            }

            return oocurences;
        }

        private static bool _IsAnagram(string s, string t)
        {
            return s.OrderBy(c => c).SequenceEqual(t.OrderBy(c => c));
        }

        private static bool _IsAnagram2(string s, string t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                var n = s.IndexOf(t[i]);
                if (n < 0)
                {
                    return false;
                }
                s = s.Remove(n, 1);
            }
            return String.IsNullOrEmpty(s);
        }

    }
}
