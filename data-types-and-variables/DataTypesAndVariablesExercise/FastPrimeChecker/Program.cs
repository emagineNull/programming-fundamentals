using System;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int i = 2; i <= range; i++)
            {
                bool isPrime = true;
                for (int k = 2; k <= Math.Sqrt(i); k++)
                {
                    if (i % k == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }

        }
    }
}
