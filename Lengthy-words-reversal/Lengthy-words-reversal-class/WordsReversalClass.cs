using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lengthy_words_reversal.Lengthy_words_reversal_class
{
    internal static class WordsReversalClass
    {
        public static string ReversWords(string? innerStr) 
        {

            if (innerStr?.Length < 5 || string.IsNullOrEmpty(innerStr) || string.IsNullOrWhiteSpace(innerStr))
            {
                return innerStr ?? string.Empty;
            }

            string outer = innerStr.TrimEnd().TrimStart();

            string[] words = outer.Split(' ');

            outer = string.Empty;

            foreach (string word in words)
            {
                if (word.Length < 5)
                {
                    outer += " " + word;
                }
                else 
                {
                    char[] chars = word.ToCharArray();
                    Array.Reverse(chars);
                    outer += " " + new string(chars);
                }
            }

            return outer;
        }
    }
}
