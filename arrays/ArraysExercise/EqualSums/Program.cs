using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += sequence[j];
                }

                for (int k = i + 1; k < sequence.Length; k++)
                {
                    rightSum += sequence[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }

                leftSum = 0;
                rightSum = 0;
            }

            Console.WriteLine("no");
        }
    }
}
