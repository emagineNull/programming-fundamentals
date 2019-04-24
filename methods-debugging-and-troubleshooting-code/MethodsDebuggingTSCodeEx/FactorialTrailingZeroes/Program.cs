using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeEnd = int.Parse(Console.ReadLine());

            BigInteger factorial = FactorialCalculator(rangeEnd);

            PrintFactorialTrailingZeroes(factorial);
        }

        static BigInteger FactorialCalculator(int rangeEnd)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= rangeEnd; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static void PrintFactorialTrailingZeroes(BigInteger factorial)
        {
            var currentDigit = 0;
            var counter = 0;
            while (currentDigit == 0)
            {
                currentDigit = (int)(factorial % 10);

                counter++;

                factorial /= 10;
            }

            Console.WriteLine(counter - 1);
        }
    }
}
