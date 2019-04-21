using System;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());
            var sum = 0;
            var combinationsCount = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int k = 1; k <= m; k++)
                {
                    sum = sum + ((i * k) * 3);
                    combinationsCount++;
                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{combinationsCount} combinations\nSum: {sum} >= {maxSum}");
                        return;
                    }
                }
            }
            
            Console.WriteLine($"{combinationsCount} combinations\nSum: {sum}");
        }
    }
}
