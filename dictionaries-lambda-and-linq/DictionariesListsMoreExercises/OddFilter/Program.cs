using System;
using System.Collections.Generic;
using System.Linq;

namespace OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var evenOnly = new List<int>();

            foreach (var number in integers)
            {
                if (number % 2 == 0)
                {
                    evenOnly.Add(number);
                }
            }

            var convertedList = new List<int>();

            foreach (var converter in evenOnly)
            {
                if (converter > evenOnly.Average())
                {
                    convertedList.Add(converter + 1);
                }
                else
                {
                    convertedList.Add(converter - 1);
                }
            }

            Console.WriteLine($"{string.Join(" ", convertedList)}");
        }
    }
}
