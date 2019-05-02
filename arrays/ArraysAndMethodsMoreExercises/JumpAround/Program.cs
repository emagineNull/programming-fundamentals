using System;
using System.Linq;

namespace JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int step = 0;
            int currentIndex = 0;
            int sum = 0;

            while (true)
            {
                if (currentIndex + step < arr.Length)
                {
                    currentIndex += step;
                    sum += arr[currentIndex];
                    step = arr[currentIndex];
                }
                else if (currentIndex - step >= 0)
                {
                    currentIndex -= step;
                    sum += arr[currentIndex];
                    step = arr[currentIndex];
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
