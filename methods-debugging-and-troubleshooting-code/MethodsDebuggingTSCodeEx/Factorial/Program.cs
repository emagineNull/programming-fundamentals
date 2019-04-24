using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeEnd = int.Parse(Console.ReadLine());

            FactorialCalculator(rangeEnd);
        }

        static void FactorialCalculator(int rangeEnd)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= rangeEnd; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
