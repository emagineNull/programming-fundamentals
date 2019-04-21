using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            var studio = 0.0;
            var doubleRoom = 0.0; 
            var suite = 0.0;
            
            switch (month)
            {
                case "May":
                case "October":
                    studio += 50 * nights;
                    doubleRoom += 65 * nights;
                    suite += 75 * nights;
                    if (nights > 7 && month != "October")
                    {
                        studio *= 0.95;
                    }
                    else if (nights > 7 && month == "October")
                    {
                        studio = 0.0;
                        studio += 50 * (nights - 1);
                        studio *= 0.95;
                    }
                    break;
                case "June":
                case "September":
                    studio += 60 * nights;
                    doubleRoom += 72 * nights;
                    suite += 82 * nights;
                    if (nights > 14 && month != "September")
                    {
                        doubleRoom *= 0.9;
                    }
                    else if (nights > 7 && month == "September")
                    {
                        studio = 0.0;
                        studio += 60 * (nights - 1);
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    studio += 68 * nights;
                    doubleRoom += 77 * nights;
                    suite += 89 * nights;
                    if (nights > 14)
                    {
                        suite *= 0.85;
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Studio: {studio:f2} lv.\nDouble: {doubleRoom:f2} lv.\nSuite: {suite:f2} lv.");
        }
    }
}
