using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Enum_HomeTask
{
    internal static class IntExtensions
    {
        public static int Factorial(this int num)
        {
            if (num < 0)
                Console.WriteLine("Menfi eded yoxdur faktorialda");
            int result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int MatchCount(this string word, string pattern)
        {          
            MatchCollection match = Regex.Matches(word, pattern);
            return match.Count;
        }
    }
}


