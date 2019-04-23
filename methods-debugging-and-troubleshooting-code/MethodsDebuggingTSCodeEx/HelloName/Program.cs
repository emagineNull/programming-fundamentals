using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            Name();
        }

        static void Name()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
