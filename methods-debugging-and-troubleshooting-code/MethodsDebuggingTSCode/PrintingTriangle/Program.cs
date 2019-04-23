using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            PrintTopPart(n);
            PrintBottomPart(n);
        }

        static void PrintTopPart(int n)
        {
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write(cols + " ");
                }

                Console.WriteLine();
            }
        }

        static void PrintBottomPart(int n)
        {
            for (int rows = n - 1; rows >= 1; rows--)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write(cols + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
