using System;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            var result = CalculateTriangleArea(width, height);

            Console.WriteLine(result);
        }

        static double CalculateTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
