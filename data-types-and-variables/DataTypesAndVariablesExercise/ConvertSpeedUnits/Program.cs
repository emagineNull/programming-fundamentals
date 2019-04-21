using System;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            double metersPerSec = distance / (hours * 60.0 * 60 + minutes * 60 + seconds);
            double kmPerH = (distance / 1000.0) / (hours + minutes / 60.0 + seconds / 60 / 60);
            double milesPerH = (distance / 1609.0) / (hours + minutes / 60.0 + seconds / 60 / 60);

            Console.WriteLine($"{metersPerSec:f6}");
            Console.WriteLine($"{kmPerH:f6}");
            Console.WriteLine($"{milesPerH:f6}");
        }
    }
}
