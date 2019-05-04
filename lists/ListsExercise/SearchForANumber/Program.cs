using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] manipulator = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> afterManip = new List<int>();

            for (int i = 0; i < manipulator[0]; i++)
            {
                afterManip.Add(sequence[i]);
            }

            for (int i = 0; i < manipulator[1]; i++)
            {
                afterManip.RemoveAt(0);
            }

            if (afterManip.Contains(manipulator[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
