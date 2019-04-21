using System;

namespace ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            var totalPrice = 0.0;

            switch (profession)
            {
                case "Athlete":
                    totalPrice = quantity * 0.7;
                    break;
                case "Businessman":
                case "Businesswoman":
                    totalPrice = quantity * 1.0;
                    break;
                case "SoftUni Student":
                    totalPrice = quantity * 1.7;
                    break;
                default:
                    totalPrice = quantity * 1.2;
                    break;
            }

            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
    }
}
