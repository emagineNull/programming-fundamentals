using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            sequence.Reverse();

            int counter = 0;
            int max = 0;
            int currentNumber = 0;
            int maxNumber = 0;
            for (int i = 0; i < sequence.Count - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    counter++;
                    currentNumber = sequence[i];
                    if (counter >= max)
                    {
                        max = counter;
                        maxNumber = currentNumber;
                    }
                }
                else
                {
                    counter = 0;
                }
            }

            for (int i = 0; i <= max; i++)
            {
                Console.Write(maxNumber + " ");
            }

            Console.WriteLine();
        }
    }
}
