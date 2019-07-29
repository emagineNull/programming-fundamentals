using System;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();

            var regex = new Regex(@"(^|(?<=\s))[A-Z][^.!?]*\W" + word + @"\W.*?(?=[\.\?\!])");

            var matchedSentences = regex.Matches(text);

            foreach (Match sentence in matchedSentences)
            {
                Console.WriteLine(sentence.Value);
            }
        }
    }
}
