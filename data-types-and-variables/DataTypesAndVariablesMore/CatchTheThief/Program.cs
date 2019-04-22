using System;

namespace CatchTheThief
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

            Console.WriteLine(largest);
        }
    }
}
