using System;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                var regex = @"^(.+)>(\d{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1$";

                Match m = Regex.Match(input, regex);

                if (m.Success)
                {
                    var nums = m.Groups[2].Value;
                    var lowerCaseLetters = m.Groups[3].Value;
                    var upperCaseLetters = m.Groups[4].Value;
                    var symbols = m.Groups[5].Value;
                    Console.WriteLine($"Password: {nums}{lowerCaseLetters}{upperCaseLetters}{symbols}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
