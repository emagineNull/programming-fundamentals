using System;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var calories = 0;

            for (int i = 1; i <= n; i++)
            {
                string ingredient = Console.ReadLine();
                ingredient = ingredient.ToLower();
                switch (ingredient)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
