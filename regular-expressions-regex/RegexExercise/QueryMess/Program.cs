using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output = new List<string>();

            var regexSpaces = new Regex(@"(%20|\+)+");
            var groupPattern = @"([^?&]+)=([^?&]+)";

            while (input != "END")
            {
                var cleared = regexSpaces.Replace(input, " ");
                var matches = Regex.Matches(cleared, groupPattern);
                var dictionary = new Dictionary<string, List<string>>();


                foreach (Match item in matches)
                {
                    var list = new List<string>();
                    if (!dictionary.ContainsKey(item.Groups[1].Value.Trim(' ')))
                    {
                        list.Add(item.Groups[2].Value.Trim(' '));
                        dictionary.Add(item.Groups[1].Value.Trim(' '), list);
                    }
                    else
                    {
                        dictionary[item.Groups[1].Value.Trim(' ')].Add(item.Groups[2].Value.Trim(' '));
                    }
                }

                var stringToPrint = new StringBuilder();
                foreach (var item in dictionary)
                {
                    stringToPrint.Append($"{item.Key}=[{string.Join(", ", item.Value)}]");
                }

                output.Add(stringToPrint.ToString());
                input = Console.ReadLine();
            }

            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
