using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortWordsSort
{
    internal class Program
    {
        static void Main()
        {
            char[] separators = { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };

            List<string> words = Console.ReadLine()
                .ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries) // could've put separators there but it would make it too messy
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}