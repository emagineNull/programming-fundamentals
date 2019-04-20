using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine($"{length * width:f2}");
        }
    }
}
