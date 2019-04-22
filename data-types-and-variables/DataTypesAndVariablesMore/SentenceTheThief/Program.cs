using System;

namespace SentenceTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string idType = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            long maximum = 0;
            long largest = long.MinValue;

            if (idType == "sbyte")
            {
                maximum = sbyte.MaxValue;
            }
            else if (idType == "int")
            {
                maximum = int.MaxValue;
            }
            else
            {
                maximum = long.MaxValue;
            }

            for (int i = 1; i <= n; i++)
            {
                long number = long.Parse(Console.ReadLine());
                if (number > maximum)
                {
                    continue;
                }
                if (largest < number)
                {
                    largest = number;
                }
            }

            double overflow = 0;

            if (largest < sbyte.MinValue)
            {
                overflow = Math.Abs(Math.Ceiling(largest * 1.0 / sbyte.MinValue));
            }
            else if (largest > sbyte.MaxValue)
            {
                overflow = Math.Ceiling(largest * 1.0 / sbyte.MaxValue);
            }
            else
            {
                overflow++;
            }

            if (overflow > 1)
            {
                Console.WriteLine($"Prisoner with id {largest} is sentenced to {overflow} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {largest} is sentenced to {overflow} year");
            }
        }
    }
}
