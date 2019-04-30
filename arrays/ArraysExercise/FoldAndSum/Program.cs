using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] upperLeft = new int[nums.Length / 4];
            int[] upperRight = new int[nums.Length / 4];

            for (int i = 0; i < upperLeft.Length; i++)
            {
                upperLeft[i] = nums[i];
            }

            Array.Reverse(upperLeft);

            for (int i = 0; i < upperRight.Length; i++)
            {
                upperRight[i] = nums[nums.Length - i - 1];
            }

            int[] middleRow = new int[nums.Length / 2];

            for (int i = 0; i < middleRow.Length; i++)
            {
                middleRow[i] = nums[i + nums.Length / 4];
            }

            int[] upperRow = new int[nums.Length / 2];
            upperLeft.CopyTo(upperRow, 0);
            upperRight.CopyTo(upperRow, upperLeft.Length);

            int[] sum = new int[nums.Length / 2];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = upperRow[i] + middleRow[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
