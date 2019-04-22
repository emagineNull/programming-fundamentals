using System;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            if (number - Math.Floor(number) > 0)
            {
                Console.WriteLine("Rainy");
                return;
            }

            if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
            {
                Console.WriteLine("Sunny");
            }
            else if (number >= int.MinValue && number <= int.MaxValue)
            {
                Console.WriteLine("Cloudy");
            }
            else if (number >= long.MinValue && number <= long.MaxValue)
            {
                Console.WriteLine("Windy");
            }
        }
    }
}
