using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var splitter = @"\W+";
            var usernames = Regex.Replace(text, splitter, " ").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var pattern = @"^[a-zA-Z][a-zA-Z0-9_]{2,24}$";
            var regex = new Regex(pattern);
            var valid = new List<string>();

            foreach (var name in usernames)
            {
                if (regex.IsMatch(name))
                {
                    valid.Add(name);
                }
            }

            var sumMax = 0;
            var first = string.Empty;
            var second = string.Empty;

            for (int i = 1; i < valid.Count; i++)
            {
                var currentSum = valid[i - 1].Length + valid[i].Length;
                if (currentSum > sumMax)
                {
                    sumMax = currentSum;
                    first = valid[i - 1];
                    second = valid[i];
                }
            }


            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
