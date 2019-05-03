using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int listLength = numbers.Count;

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];
                if (currentNumber < 0)
                {
                    numbers.Remove(currentNumber);
                    listLength--;
                    i--;
                }
            }

            numbers.Reverse();

            if (listLength == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
