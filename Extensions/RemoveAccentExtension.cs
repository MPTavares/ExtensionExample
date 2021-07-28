using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtensionExample.Extensions
{
    public static class RemoveAccentExtension
    {
        public static string RemoveAccent(this string word)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var temp = Encoding.GetEncoding("iso-8859-7").GetBytes(word);
            word = Encoding.UTF8.GetString(temp);
            return Regex.Replace(word, "[^0-9A-Za-z]", "");
        }
    }
}
