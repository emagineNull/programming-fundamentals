using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new char[] { ' ', ',', '?', '!', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                var currentWord = text[i];

                var charArr = currentWord.ToCharArray();
                Array.Reverse(charArr);

                var reversedWord = new string(charArr);

                if (currentWord.Equals(reversedWord))
                {
                    if (!palindromes.Contains(currentWord))
                    {
                        palindromes.Add(currentWord);
                    }
                }
            }
            
            Console.WriteLine(string.Join(", ", palindromes.OrderBy(n => n)));
        }
    }
}
