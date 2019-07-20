using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\b(?<day>\d{2})(.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");

            var datesString = Console.ReadLine();

            var dates = regex.Matches(datesString);

            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
