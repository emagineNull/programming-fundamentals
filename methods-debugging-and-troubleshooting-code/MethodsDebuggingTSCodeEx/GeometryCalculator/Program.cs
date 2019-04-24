using System;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            FigureName(name);
        }

        static void FigureName(string name)
        {
            if (name == "triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Triangle(side, height):f2}");
            }
            else if (name == "square")
            {
                var side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Square(side):f2}");
            }
            else if (name == "rectangle")
            {
                var width = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Rectangle(width, height):f2}");
            }
            else
            {
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Circle(radius):f2}");
            }
        }

        static double Triangle(double side, double height)
        {
            var area = side * height / 2;
            return area;
        }

        static double Square(double side)
        {
            var area = side * side;
            return area;
        }

        static double Rectangle(double width, double height)
        {
            var area = width * height;
            return area;
        }

        static double Circle(double radius)
        {
            var area = Math.PI * radius * radius;
            return area;
        }
    }
}
