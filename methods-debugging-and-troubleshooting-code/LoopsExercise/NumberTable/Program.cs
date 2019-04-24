using System;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintNumberTable(n);
        }

        static void PrintNumberTable(int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int num = row + col + 1;

                    if (num <= n)
                    {
                        Console.Write(num + " ");
                    }

                    if (num > n)
                    {
                        num = 2 * n - num;
                        Console.Write(num + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
