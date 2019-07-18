using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\+359( |\-)2\1\d{3}\1\d{4}\b");

            var numbers = Console.ReadLine();

            var matchedPhones = regex.Matches(numbers);

            var phonesMatched = matchedPhones
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", phonesMatched));
        }
    }
}
