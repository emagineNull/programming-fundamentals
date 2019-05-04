using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] detonator = Console.ReadLine().Split();

            int element = int.Parse(detonator[0]);
            int power = int.Parse(detonator[1]);

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == element)
                {
                    int left = Math.Max(i - power, 0);
                    int right = Math.Min(i + power, sequence.Count - 1);

                    int length = right - left + 1;
                    sequence.RemoveRange(left, length);
                    i--;
                }
            }
            Console.WriteLine(sequence.Sum());
        }
    }
}
