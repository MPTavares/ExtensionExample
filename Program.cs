using ExtensionExample.Extensions;
using System;

namespace ExtensionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Name", "Ána", "Home", "afã", "Sun", "Socorram-me, subi no ônibus em Marrocos" };
            foreach (var word in words)
            {
                string wordChanged = word.ToLower().OnlyLettersAndNumbers();

                bool isPalindrome = (wordChanged == wordChanged.ReverseString());

                string option = isPalindrome ? "is" : "not is";

                Console.WriteLine($"'{word}' {option} palindrome.");                
            }

            Console.ReadLine();
        }
    }
}
