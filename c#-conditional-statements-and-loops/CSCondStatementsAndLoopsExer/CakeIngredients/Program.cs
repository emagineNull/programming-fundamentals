using System;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            var ingredients = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredients++;
                ingredient = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {ingredients} ingredients.");
        }
    }
}
