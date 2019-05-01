using System;

namespace SieveOfErathosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }

            primes[0] = false;
            primes[1] = false;

            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write(i + " ");
                    for (int j = 2; j * i <= n; j++)
                    {
                        primes[i * j] = false;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
