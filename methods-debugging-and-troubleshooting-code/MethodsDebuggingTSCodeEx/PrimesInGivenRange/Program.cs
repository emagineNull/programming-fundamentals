using System;
using System.Collections.Generic;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            string numbers = String.Join(", ", FindPrimesInRange(startNum, endNum).ToArray());
            Console.WriteLine(numbers);
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primeNums = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                var isPrime = true;
                if (i < 2)
                {
                    isPrime = false;
                    continue;
                }
                for (int k = 2; k <= Math.Sqrt(i); k++)
                {
                    if (i % k == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNums.Add(i);
                }
            }

            return primeNums;
        }
    }
}
