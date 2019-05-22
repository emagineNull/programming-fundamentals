using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] input = new string[3];
            var logsAggregator = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ').ToArray();

                if (!logsAggregator.ContainsKey(input[1]))
                {
                    logsAggregator.Add(input[1], new SortedDictionary<string, int>());
                }

                if (!logsAggregator[input[1]].ContainsKey(input[0]))
                {
                    logsAggregator[input[1]].Add(input[0], int.Parse(input[2]));
                }
                else
                {
                    logsAggregator[input[1]][input[0]] += int.Parse(input[2]);
                }
            }

            foreach (var user in logsAggregator)
            {
                List<string> ips = user.Value.Keys.Distinct().ToList();

                Console.WriteLine($"{user.Key}: {user.Value.Values.Sum()} [{string.Join(", ", ips)}]");
            }
        }
    }
}
