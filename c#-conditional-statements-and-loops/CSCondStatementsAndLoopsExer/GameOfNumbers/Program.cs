using System;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());
            var combinationsCount = 0;
            var firstNum = 0;
            var secondNum = 0;
            var magical = false;

            for (int i = n; i <= m; i++)
            {
                for (int k = n; k <= m; k++)
                {
                    combinationsCount++;
                    if (i + k == magicNum)
                    {
                        firstNum = i;
                        secondNum = k;
                        magical = true;
                    }
                }
            }

            if (magical)
            {
                Console.WriteLine($"Number found! {firstNum} + {secondNum} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{combinationsCount} combinations - neither equals {magicNum}");
            }
        }
    }
}
