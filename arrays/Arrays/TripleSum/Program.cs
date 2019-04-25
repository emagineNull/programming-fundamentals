using System;
using System.Linq;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int[] arr = text.Split(' ').Select(int.Parse).ToArray();

            bool isSum = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    for (int l = 0; l < arr.Length; l++)
                    {
                        if (arr[i] + arr[k] == arr[l] && k > i)
                        {
                            isSum = true;
                            Console.WriteLine($"{arr[i]} + {arr[k]} == {arr[l]}");
                            break;
                        }
                    }
                }
            }

            if (isSum == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
