using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = arr.Length / 4;

            int[] first = arr.Take(k).Reverse().ToArray();
            int[] last = arr.Reverse().Take(k).ToArray();
            int[] leftOfArr = arr.Skip(k).Take(2 * k).ToArray();

            int[] concatenatedArr = first.Concat(last).ToArray();

            int[] sumArr = concatenatedArr.Select((x, index) => x + leftOfArr[index]).ToArray();

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
