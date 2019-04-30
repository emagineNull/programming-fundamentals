using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = int.Parse(Console.ReadLine());

            int[] sum = new int[nums.Length];

            for (int r = 0; r < k; r++)
            {
                int lastElement = nums[nums.Length - 1];
                for (int i = nums.Length - 1; i > 0; i--)
                {
                    nums[i] = nums[i - 1];
                }
                nums[0] = lastElement;
                for (int j = 0; j < nums.Length; j++)
                {
                    sum[j] += nums[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
