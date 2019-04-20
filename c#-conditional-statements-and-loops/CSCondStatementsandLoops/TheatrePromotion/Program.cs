using System;

namespace TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayType = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }

            if (dayType == "Weekday")
            {
                if (18 < age && age <= 64)
                {
                    Console.WriteLine("18$");
                }
                else
                {
                    Console.WriteLine("12$");
                }
            }
            else if (dayType == "Weekend")
            {
                if (age > 18 && age <= 64)
                {
                    Console.WriteLine("20$");
                }
                else
                {
                    Console.WriteLine("15$");
                }
            }
            else
            {
                if (age <= 18)
                {
                    Console.WriteLine("5$");
                }
                else if (age <= 64)
                {
                    Console.WriteLine("12$");
                }
                else
                {
                    Console.WriteLine("10$");
                }
            }
        }
    }
}
