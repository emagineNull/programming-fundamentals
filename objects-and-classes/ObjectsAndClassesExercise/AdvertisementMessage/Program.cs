using System;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.",
            "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            var events = new string[] { "Now I feel good.", "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.", "I feel great!" };

            var authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            var cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < n; i++)
            {
                var rand = new Random();
                var randomPhrase = phrases[rand.Next(phrases.Length)];
                var randomEvent = events[rand.Next(events.Length)];
                var randomAuthor = authors[rand.Next(authors.Length)];
                var randomCity = cities[rand.Next(cities.Length)];

                Console.WriteLine($"{randomPhrase} {randomEvent} {randomAuthor} - {randomCity}.");
            }
        }
    }
}

