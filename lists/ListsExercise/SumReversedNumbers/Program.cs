using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            long sum = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
                int reversed = 0;
                while (sequence[i] > 0)
                {
                    int number = sequence[i] % 10;
                    reversed = reversed * 10 + number;
                    sequence[i] /= 10;
                }
                
                sum += reversed;
            }

            Console.WriteLine(sum);
        }
    }
}
