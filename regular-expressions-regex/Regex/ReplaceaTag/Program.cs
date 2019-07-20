using System;
using System.Text.RegularExpressions;

namespace ReplaceaTag
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            while (text != "end")
            {
                var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                var replacement = @"[URL href=$1]$2[/URL]";
                var replaced = Regex.Replace(text, pattern, replacement);

                Console.WriteLine(replaced);

                text = Console.ReadLine();
            }
        }
    }
}
