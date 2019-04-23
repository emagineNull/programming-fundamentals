using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void ClosestToCenter(double x1, double y1, double x2, double y2)
        {
            double firstCoordinates = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
            double secoundCoordinates = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

            if (firstCoordinates < secoundCoordinates)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else if (firstCoordinates > secoundCoordinates)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }

        static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double firstPair = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double secondPair = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

            if (firstPair > secondPair)
            {
                ClosestToCenter(x1, y1, x2, y2);
            }
            else if (firstPair < secondPair)
            {
                ClosestToCenter(x3, y3, x4, y4);
            }
            else if (firstPair == secondPair)
            {
                ClosestToCenter(x1, y1, x2, y2);
            }
        }
    }
}
