using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            var numbers = new List<int>();
            var nonNumbers = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString().All(char.IsDigit))
                {
                    numbers.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    nonNumbers.Add(input[i]);
                }
            }

            var take = new List<int>();
            var skip = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    take.Add(numbers[i]);
                }
                else
                {
                    skip.Add(numbers[i]);
                }
            }

            var skipCounter = 0;

            for (int i = 0; i < take.Count; i++)
            {
                var result = nonNumbers.Skip(skipCounter).Take(take[i]).ToList();

                Console.Write(string.Join("", result));
                skipCounter += take[i] + skip[i];
            }

            Console.WriteLine();
        }
    }
}
