using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\b(?:0x)?[0-9A-F]+\b");

            var input = Console.ReadLine();

            var hex = regex.Matches(input)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", hex));
        }
    }
}
