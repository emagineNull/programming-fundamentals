using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, KeyValuePair<double, string>>();
            var matches = new List<string>();
            var input = Console.ReadLine();

            var regex = new Regex(@"([A-Z]{2})([0-9]{1,2}\.[0-9]{1,2})([A-Za-z]+)\|");

            var city = string.Empty;
            var temperature = 0.0;
            var weather = string.Empty;
            

            while (input != "end")
            {
                var currentMatch = regex.Match(input);

                if (currentMatch.Success)
                {
                    city = currentMatch.Groups[1].ToString();
                    temperature = double.Parse(currentMatch.Groups[2].ToString());
                    if (temperature > 50.00)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    weather = currentMatch.Groups[3].ToString();

                    if (!cities.ContainsKey(city))
                    {
                        cities.Add(city, new KeyValuePair<double, string>(temperature, weather));
                    }
                    else
                    {
                        cities[city] = new KeyValuePair<double, string>(temperature, weather);
                    }
                }
                

                input = Console.ReadLine();
            }

            foreach (var currentCity in cities.OrderBy(x => x.Value.Key))
            {
                Console.WriteLine($"{currentCity.Key} => {currentCity.Value.Key:F2} => {currentCity.Value.Value}");
            }
        }
    }
}
