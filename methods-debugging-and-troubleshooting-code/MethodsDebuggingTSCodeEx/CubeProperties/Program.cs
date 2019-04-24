using System;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            PrintResult(name, side);
        }

        static double CalculateFaceDiagonals(double side)
        {
            double faceDiagonals = Math.Sqrt(Math.Pow(side, 2) * 2);
            return faceDiagonals;
        }

        static double CalculateSpaceDiagonals(double side)
        {
            double spaceDiagonals = Math.Sqrt(Math.Pow(side, 2) * 3);
            return spaceDiagonals;
        }

        static double CalculateVolume(double side)
        {
            double volume = Math.Pow(side, 3);
            return volume;
        }

        static double CalculateArea(double side)
        {
            double area = Math.Pow(side, 2) * 6;
            return area;
        }

        static void PrintResult(string name, double side)
        {
            if (name == "face")
            {
                Console.WriteLine($"{CalculateFaceDiagonals(side):f2}");
            }
            else if (name == "space")
            {
                Console.WriteLine($"{CalculateSpaceDiagonals(side):f2}");
            }
            else if (name == "volume")
            {
                Console.WriteLine($"{CalculateVolume(side):f2}");
            }
            else
            {
                Console.WriteLine($"{CalculateArea(side):f2}");
            }
        }
    }
}
