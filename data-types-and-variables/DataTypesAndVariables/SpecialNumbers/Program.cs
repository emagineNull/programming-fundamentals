using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var number = i;
                var sum = 0;

                while (number != 0)
                {
                    var currentDigit = number % 10;

                    number /= 10;

                    sum += currentDigit;
                }

                var isSpecial = false;

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }

                Console.WriteLine(i + " -> " + isSpecial);
            }
        }
    }
}
