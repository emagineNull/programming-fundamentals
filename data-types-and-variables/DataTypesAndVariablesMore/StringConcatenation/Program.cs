using System;

namespace StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string finalString = string.Empty;
            string word = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                word = Console.ReadLine();
                if (evenOrOdd == "even")
                {
                    if (i % 2 == 0)
                    {
                        finalString += word + delimiter;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        finalString += word + delimiter;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(finalString.Remove(finalString.Length - 1));
        }
    }
}
