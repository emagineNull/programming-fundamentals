using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort();
            //numbers.Add(int.MaxValue);

            //var currentNumber = numbers[0];
            //var currentCount = 1;

            //for (int i = 1; i < numbers.Count; i++)
            //{
            //    if (currentNumber == numbers[i])
            //    {
            //        currentCount++;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{currentNumber} -> {currentCount}");
            //        currentNumber = numbers[i];
            //        currentCount = 1;
            //    }
            //}

            int[] numbersCount = new int[1001];

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];

                numbersCount[currentNumber]++;
            }

            for (int i = 0; i < numbersCount.Length; i++)
            {
                var currentNumber = numbersCount[i];
                if (currentNumber > 0)
                {
                    Console.WriteLine($"{i} -> {currentNumber}");
                }
            }
        }
    }
}
