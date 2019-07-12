using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConvertFromBase_10ToBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').ToArray();
            var converted = new List<BigInteger>();

            var baseN = int.Parse(nums[0]);
            var decNum = BigInteger.Parse(nums[1]);

            if (baseN == 10)
            {
                Console.WriteLine(decNum);
                return;
            }

            var currentNum = decNum;

            while (currentNum >= 1)
            {
                var currentRemainder = currentNum % baseN;

                converted.Add(currentRemainder);

                currentNum -= currentRemainder;
                currentNum /= baseN;
            }

            converted.Reverse();

            Console.WriteLine(string.Join(string.Empty, converted));
        }
    }
}
