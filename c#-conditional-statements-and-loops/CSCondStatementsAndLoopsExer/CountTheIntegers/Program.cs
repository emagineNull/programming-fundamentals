using System;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 0;
            var numbersCount = 0;
            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    numbersCount++;
                }
                catch
                {
                    Console.WriteLine(numbersCount);
                    break;
                }
            }
        }
    }
}
