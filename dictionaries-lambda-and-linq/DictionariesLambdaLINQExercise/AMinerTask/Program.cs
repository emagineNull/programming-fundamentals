using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> miner = new Dictionary<string, int>();

            string command = Console.ReadLine();

            string resource = string.Empty;
            int counter = 1;
            while (command != "stop")
            {
                if (counter % 2 == 1)
                {
                    if (miner.ContainsKey(command))
                    {
                        resource = command;
                    }
                    else
                    {
                        resource = command;
                        miner[resource] = 0;
                    }
                }
                else
                {
                    miner[resource] += int.Parse(command);
                }

                counter++;
                command = Console.ReadLine();
            }

            foreach (var kvp in miner)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
