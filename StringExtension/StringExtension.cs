using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringExtension
{
    public static  class StringExtension
    {
        public static int MatchCount(this string word, string target)
        {
            int counte = 0;
            return Regex.Count(target, @"\b{0}\b");
        }
    }
}

