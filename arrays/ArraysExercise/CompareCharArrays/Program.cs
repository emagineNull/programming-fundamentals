using System;
using System.Linq;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int smaller = Math.Min(arr1.Length, arr2.Length);

            bool equal = true;
            for (int i = 0; i < smaller; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    continue;
                }
                else if (arr1[i] > arr2[i])
                {
                    equal = false;
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                    break;
                }
                else if (arr1[i] < arr2[i])
                {
                    equal = false;
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                    break;
                }
            }

            if (equal)
            {
                if (arr1.Length > arr2.Length)
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                }
                else
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                }
            }
        }
    }
}
