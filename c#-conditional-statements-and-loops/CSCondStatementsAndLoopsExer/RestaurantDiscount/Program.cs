using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacity = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = string.Empty;
            var price = 0.0;

            if (capacity <= 50)
            {
                price = 2500;
                hall = "Small Hall";
            }
            else if (capacity <= 100)
            {
                price = 5000;
                hall = "Terrace";
            }
            else if (capacity <= 120)
            {
                price = 7500;
                hall = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (package == "Normal")
            {
                price += 500;
                price *= 0.95;
            }
            else if (package == "Gold")
            {
                price += 750;
                price *= 0.9;
            }
            else
            {
                price += 1000;
                price *= 0.85;
            }

            Console.WriteLine($"We can offer you the {hall}\nThe price per person is {price / capacity * 1.0:f2}$");
        }
    }
}
