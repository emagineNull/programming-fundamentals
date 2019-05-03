using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowercase = new List<string>();
            List<string> uppercase = new List<string>();
            List<string> mixedcase = new List<string>();

            foreach (var word in text)
            {
                if (word.All(char.IsUpper))
                {
                    uppercase.Add(word);
                }
                else if (word.All(char.IsLower))
                {
                    lowercase.Add(word);
                }
                else
                {
                    mixedcase.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowercase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedcase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", uppercase)}");
        }
    }
}
