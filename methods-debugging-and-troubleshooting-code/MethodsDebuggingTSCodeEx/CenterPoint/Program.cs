using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestToCenter(x1, y1, x2, y2);
        }

        static void PrintClosestToCenter(double x1, double y1, double x2, double y2)
        {
            double firstCoordinates = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double secoundCoordinates = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (firstCoordinates < secoundCoordinates)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
