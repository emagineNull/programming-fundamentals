using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            
            var regex = new Regex(@"(^|(?<=\s))[A-Za-z]+([0-9]+)?([\._-][A-z0-9]+)?@\w+-?\w+(?:\.\w+)+");

            var emails = regex.Matches(input);

            var emailMatches = emails.Cast<Match>().Select(a => a.Value).ToArray();

            foreach (var email in emailMatches)
            {
                Console.WriteLine(email);
            }
        }
    }
}
