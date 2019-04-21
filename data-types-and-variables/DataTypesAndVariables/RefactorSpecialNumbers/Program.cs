using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int total = 0;
                int currentNumber = i;
                while (currentNumber != 0)
                {
                    total += currentNumber % 10;
                    currentNumber /= 10;
                }
                bool isSpecial = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
