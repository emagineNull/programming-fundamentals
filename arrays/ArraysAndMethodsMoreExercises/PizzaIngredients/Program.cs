using System;
using System.Linq;

namespace PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ');
            int length = int.Parse(Console.ReadLine());

            string[] usedIngredients = new string[100];

            int counter = 0;
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (counter == 10)
                {
                    break;
                }
                int elementLength = ingredients[i].ToCharArray().Count();
                if (elementLength == length)
                {
                    usedIngredients[i] = ingredients[i];
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    counter++;
                }
            }

            usedIngredients = usedIngredients.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", usedIngredients)}.");
        }
    }
}
