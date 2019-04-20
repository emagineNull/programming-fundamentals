using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var count = 1;

            while (count <= 10)
            {
                Console.WriteLine($"{number} X {count} = {number * count}");
                count++;
            }
        }
    }
}
