using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:\n{energy * (volume / 100.0)}kcal, {sugar * (volume / 100.0)}g sugars");
        }
    }
}
