using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lengthy_words_reversal.Lengthy_words_reversal_class
{
    internal static class WordsReversalClass
    {
        public static List<string> ReversWords(string? innerStr) 
        {
            if (innerStr?.Length < 5 )
            {
                return new List<string>() { innerStr };
            }

            if (string.IsNullOrWhiteSpace(innerStr)) 
            {
                throw new Exception("Empty string!");
            }

            var outer = innerStr.TrimEnd().TrimStart().Split(' ').ToList();

            var reversed = outer.Select(selector => selector.Length > 5 ? new string(selector.Reverse().ToArray()) : selector).ToList();

            return reversed;
        }

        public static void Show(List<string> strings) 
        {
            Console.WriteLine();
            foreach (var s in strings)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
        }
    }
}
