using System;
using System.Linq;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                int currentPos = sequence[i];
                for (int j = i; j < sequence.Length - 1; j++)
                {
                    if (diff == Math.Abs(currentPos - sequence[j+1]))
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
