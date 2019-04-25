using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            double[] numbers = text.Split(' ').Select(double.Parse).ToArray();

            foreach (var number in numbers)
            {
                var roundedNumber = Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number} => {roundedNumber}");
            }
        }
    }
}
