using System;
using System.Collections.Generic;

namespace ClosestTwoPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public string Display()
        {
            return $"({X}, {Y})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPoints = int.Parse(Console.ReadLine());
            var allPoints = new List<Point>();

            for (int i = 0; i < numberOfPoints; i++)
            {
                var currentPoint = ReadPoint();

                allPoints.Add(currentPoint);
            }

            var minDistance = double.MaxValue;
            Point firstMinPoint = null;
            Point secondMinPoint = null;

            for (int i = 0; i < numberOfPoints; i++)
            {
                for (int j = i + 1; j < numberOfPoints; j++)
                {
                    var firstPoint = allPoints[i];
                    var secondPoint = allPoints[j];

                    var currentDistance = Distance(firstPoint, secondPoint);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstMinPoint = firstPoint;
                        secondMinPoint = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");

            Console.WriteLine(firstMinPoint.Display());
            Console.WriteLine(secondMinPoint.Display());
        }

        static Point ReadPoint()
        {
            var pointData = Console.ReadLine()
                .Split(' ');

            var point = new Point
            {
                X = int.Parse(pointData[0]),
                Y = int.Parse(pointData[1])
            };

            return point;
        }

        static double Distance(Point first, Point second)
        {
            var xDiff = first.X - second.X;
            var xPow = xDiff * xDiff;

            var yDiff = first.Y - second.Y;
            var yPow = yDiff * yDiff;
            return Math.Sqrt(xPow + yPow);
        }
    }
}
