using System;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int max = 0;
            int counter = 0;
            int frequent = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                int currentNum = sequence[i];
                for (int j = 0; j <= i; j++)
                {
                    if (sequence[j] == currentNum)
                    {
                        counter++;
                        if (counter > max)
                        {
                            max = counter;
                            frequent = currentNum;
                        }
                    }
                }
                counter = 0;
            }

            Console.WriteLine(frequent);
        }
    }
}
