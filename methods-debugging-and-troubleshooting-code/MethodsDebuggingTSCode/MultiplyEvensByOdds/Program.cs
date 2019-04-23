using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            var result = GetMultipleOfEvensAndOdds(n);

            Console.WriteLine(result);
        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            var evenSum = GetSumOfEvenDigits(number);
            var oddSum = GetSumOfOddDigits(number);

            return evenSum * oddSum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            return GetSumOfDigits(number, true);
        }

        static int GetSumOfOddDigits(int number)
        {
            return GetSumOfDigits(number, false);
        }

        static int GetSumOfDigits(int number, bool even)
        {
            var remainder = even ? 0 : 1;
            int sum = 0;

            while (number > 0)
            {
                var currentDigit = number % 10;
                number /= 10;

                if (currentDigit % 2 == remainder)
                {
                    sum += currentDigit;
                }
            }

            return sum;
        }
    }
}
