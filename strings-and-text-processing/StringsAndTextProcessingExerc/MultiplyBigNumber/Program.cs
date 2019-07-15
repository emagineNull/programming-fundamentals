using System;
using System.Collections.Generic;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Console.ReadLine().TrimStart('0');
            var num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var decimalReminder = 0;
            var currentMultiplication = 0;
            var result = new List<int>();

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                var currentDigit = num1[i] - '0';
                currentMultiplication = currentDigit * num2;
                currentMultiplication += decimalReminder;

                result.Add(currentMultiplication % 10);

                decimalReminder = currentMultiplication / 10;
            }

            if (decimalReminder > 0)
            {
                result.Add(decimalReminder);
            }

            result.Reverse();

            Console.WriteLine(string.Join("", result));
        }
    }
}
