using System;
using System.Linq;

namespace ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumbers = int.Parse(Console.ReadLine());
            int[] numbers = new int[totalNumbers];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            int[] reversedNumbers = numbers.Reverse().ToArray();

            for (int i = 0; i < reversedNumbers.Length; i++)
            {
                Console.WriteLine(reversedNumbers[i]);
            }
        }
    }
}
