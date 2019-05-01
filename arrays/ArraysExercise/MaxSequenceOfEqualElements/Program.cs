using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int start = 0;
            int counter = 0;
            int max = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    counter++;
                    if (counter > max)
                    {
                        start = i - counter;
                        max = counter;
                    }
                }
                else
                {
                    counter = 0;
                }
            }

            for (int i = start + 1; i <= start + max + 1; i++)
            {
                Console.Write(sequence[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
