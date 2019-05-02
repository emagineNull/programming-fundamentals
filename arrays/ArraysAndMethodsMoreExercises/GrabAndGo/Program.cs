using System;
using System.Linq;

namespace GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long input = long.Parse(Console.ReadLine());

            long sum = 0;
            long lastOccurence = 0;
            bool doesOccur = false;

            for (int i = arr.Length - 1; i >= 1; i--)
            {
                if (arr[i] == input)
                {
                    lastOccurence = i;
                    doesOccur = true;
                    break;
                }
            }

            if (doesOccur)
            {
                for (int i = 0; i < lastOccurence; i++)
                {
                    sum += arr[i];
                }

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
            
        }
    }
}
