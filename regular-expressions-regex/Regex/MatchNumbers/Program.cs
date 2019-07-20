using System;
using System.Text.RegularExpressions;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");

            var numberString = Console.ReadLine();

            var numbers = regex.Matches(numberString);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }
        }
    }
}
