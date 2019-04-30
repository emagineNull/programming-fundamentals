using System;
using System.Linq;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();
 
            var largest = Math.Max(arr1.Length, arr2.Length);
            var smallest = Math.Min(arr1.Length, arr2.Length);

            int leftToRightCounter = 0;
            for (int i = 0; i < smallest; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    leftToRightCounter++;
                }
                else
                {
                    break;
                }
            }

            int rightToLeftCounter = 0;
            for (int i = 1; i <= smallest; i++)
            {
                if (arr1[arr1.Length - i] == arr2[arr2.Length - i])
                {
                    rightToLeftCounter++;
                }
                else
                {
                    break;
                }
            }

            if (leftToRightCounter >= rightToLeftCounter)
            {
                Console.WriteLine(leftToRightCounter);
            }
            else if (rightToLeftCounter > leftToRightCounter)
            {
                Console.WriteLine(rightToLeftCounter);
            }
            else
            {
                Console.WriteLine(leftToRightCounter);
            }
        }
    }
}
