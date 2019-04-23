using System;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var n = int.Parse(Console.ReadLine());

            PrintDashes(n);
            PrintBody(n);
            PrintDashes(n);
        }

        static void PrintBody(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('-');

                for (int k = 0; k < n - 1; k++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine('-');
            }
        }

        static void PrintDashes(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
    }
}
