using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string model = string.Empty;
            double radius = 0;
            uint height = 0;
            decimal volume = 0.0m;

            decimal biggestKegVol = decimal.MinValue;
            string biggestKeg = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                model = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = uint.Parse(Console.ReadLine());
                volume = (decimal)(Math.PI * radius * radius * height);
                if (volume > biggestKegVol)
                {
                    biggestKegVol = volume;
                    biggestKeg = model;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
