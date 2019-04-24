using System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintChristmasTree(n);
        }

        static void PrintChristmasTree(int treeSize)
        {
            for (int row = 0; row <= treeSize; row++)
            {
                Console.Write(new string(' ', treeSize - row));
                Console.Write(new string('*', row));
                Console.Write(" | ");
                Console.Write(new string('*', row));
                Console.WriteLine(new string(' ', treeSize - row));
            }
        }
    }
}

