using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionExample.Extensions
{
    public static class ReverseStringExtension
    {
        public static string ReverseString (this string word)
        {
            word = String.Concat(word.Reverse());
            return word;
        }
    }
}
