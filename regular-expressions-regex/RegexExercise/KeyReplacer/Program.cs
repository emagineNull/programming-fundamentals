using System;
using System.Text.RegularExpressions;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyInput = Console.ReadLine();
            var textInput = Console.ReadLine();

            var patern = $@"^([a-zA-Z]+)[\|<\\](.+)[\|<\\]([a-zA-Z]+)$";
            var regex = new Regex(patern);

            var match = regex.Match(keyInput);
            var start = match.Groups[1].Value;
            var end = match.Groups[3].Value;

            var wordPattern = $@"{start}(?!{end})(.*?){end}";
            var matchCollection = Regex.Matches(textInput, wordPattern);

            if (matchCollection.Count > 0)
            {
                foreach (Match item in matchCollection)
                {
                    Console.Write(item.Groups[1].Value);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
