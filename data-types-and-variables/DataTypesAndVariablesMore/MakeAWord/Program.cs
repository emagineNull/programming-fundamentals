using System;

namespace MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                word += letter.ToString();
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
