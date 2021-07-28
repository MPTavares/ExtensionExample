using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionExample.Extensions
{
    public static class InvertionExtension
    {
        public static string Invertion (this string word)
        {
            word = String.Concat(word.Reverse());
            return word;
        }
    }
}
