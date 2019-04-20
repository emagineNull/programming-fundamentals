using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var currentNumber = 1;
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(currentNumber);
                sum += currentNumber;
                currentNumber += 2;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
