using System;

namespace RectanglePosition
{
    class Rectangle
    {
        public int Top { get; set; }

        public int Left { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public int CalculateArea()
        {
            return Width * Height;
        }

        public bool IsInside(Rectangle other)
        {
            return Left >= other.Left
                && Right <= other.Right
                && Bottom <= other.Bottom
                && Top >= other.Top;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var first = ReadRectangle();
            var second = ReadRectangle();

            var result = first.IsInside(second);

            Console.WriteLine(result ? "Inside" : "Not inside");
        }

        static Rectangle ReadRectangle()
        {
            var rectData = Console.ReadLine()
                .Split(' ');

            return new Rectangle
            {
                Left = int.Parse(rectData[0]),
                Top = int.Parse(rectData[1]),
                Width = int.Parse(rectData[2]),
                Height = int.Parse(rectData[3])
            };
        }
    }
}
