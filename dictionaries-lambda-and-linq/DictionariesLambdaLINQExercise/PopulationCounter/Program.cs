using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').ToArray();
            var countries = new Dictionary<string, Dictionary<string, long>>();
            
            while (input[0] != "report")
            {
                if (!countries.ContainsKey(input[1]))
                {
                    countries.Add(input[1], new Dictionary<string, long>());
                }

                if (!countries[input[1]].ContainsKey(input[0]))
                {
                    countries[input[1]].Add(input[0], long.Parse(input[2]));
                }
                else
                {
                    countries[input[1]][input[0]] = long.Parse(input[2]);
                }

                input = Console.ReadLine().Split('|').ToArray();
            }

            foreach (var country in countries.OrderByDescending(c => c.Value.Sum(t => t.Value)))
            {
                List<long> sum = country.Value.Select(p => p.Value).ToList();

                Console.WriteLine($"{country.Key} (total population: {sum.Sum()})");

                foreach (var city in country.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
