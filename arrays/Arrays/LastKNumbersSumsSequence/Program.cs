using System;

namespace LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] seq = new long[n];

            seq[0] = 1;
            for (int current = 1; current < seq.Length; current++)
            {
                int start = Math.Max(0, current - k);
                int end = current - 1;
                long sum = 0;

                for (int prev = start; prev <= end; prev++)
                {
                    sum += seq[prev];
                }

                seq[current] = sum;
            }
            for (int i = 0; i < seq.Length; i++)
            {
                Console.WriteLine(seq[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
