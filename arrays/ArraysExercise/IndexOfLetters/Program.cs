using System;
using System.Linq;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string lowercaseText = Console.ReadLine();
            char[] arr = lowercaseText.ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} -> {arr[i] - 97}");
            }

            Console.WriteLine();
        }
    }
}
