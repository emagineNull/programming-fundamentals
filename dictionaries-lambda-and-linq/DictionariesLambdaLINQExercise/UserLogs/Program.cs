using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', '=').ToArray();
            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();

            while (input[0] != "end")
            {
                string ip = input[1];
                string user = input[5];

                if (!users.ContainsKey(user))
                {
                    users.Add(user, new Dictionary<string, int>());
                }

                if (!users[user].ContainsKey(ip))
                {
                    users[user].Add(ip, 0);
                }

                users[user][ip]++;

                input = Console.ReadLine().Split(' ', '=').ToArray();
            }

            var orderedUsers = users.OrderBy(x => x.Key).ToList();

            foreach (var kvp in orderedUsers)
            {
                Console.WriteLine(kvp.Key + ":");
                int counter = 1;
                foreach (var ipAndTimes in kvp.Value)
                {
                    if (kvp.Value.Count == counter)
                    {
                        Console.WriteLine($"{ipAndTimes.Key} => {ipAndTimes.Value}.");
                        break;
                    }
                    Console.Write($"{ipAndTimes.Key} => {ipAndTimes.Value}, ");
                    counter++;
                }
            }
        }
    }
}