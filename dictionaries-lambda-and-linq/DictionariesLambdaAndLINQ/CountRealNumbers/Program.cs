using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numbersCount.ContainsKey(number))
                {
                    numbersCount[number] = 0;
                }

                numbersCount[number]++;
            }

            foreach (var kvp in numbersCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
