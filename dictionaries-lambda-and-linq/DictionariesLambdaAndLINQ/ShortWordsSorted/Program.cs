using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split( new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .Select(w => w.ToLower())
                .OrderBy(w => w)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
