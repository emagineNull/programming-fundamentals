using System;
using System.Linq;
using System.Collections.Generic;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var personCards = new Dictionary<string, string>();

            string person = Console.ReadLine().Split(':').ToString();

            while (person != "JOKER")
            {
                string[] cards = Console.ReadLine().Split(' ', ',');
                if (personCards.ContainsKey(person))
                {

                    if (true)
                    {

                    }
                }
            }
        }
    }
}
