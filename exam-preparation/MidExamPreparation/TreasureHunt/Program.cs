using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initialLoot = Console.ReadLine().Split('|');

            var loot = new List<string>(initialLoot);

            string command = Console.ReadLine();

            while (command != "Yohoho!")
            {
                string[] commandParts = command.Split();

                string action = commandParts[0];

                if (action == "Loot")
                {
                    for (int i = 1; i < commandParts.Length; i++)
                    {
                        if (!loot.Contains(commandParts[i]))
                        {
                            loot.Insert(0, commandParts[i]);
                        }
                    }
                }
                else if (action == "Drop")
                {
                    int index = int.Parse(commandParts[1]);

                    if (index >= 0 && index < loot.Count)
                    {
                        string removed = loot[index];
                        loot.RemoveAt(index);
                        loot.Add(removed);
                    }
                }
                else if (action == "Steal")
                {
                    int count = int.Parse(commandParts[1]);

                    var stolenLoot = new List<string>();

                    if (count > loot.Count)
                    {
                        stolenLoot = loot;
                        Console.WriteLine(string.Join(", ", stolenLoot));
                        loot.Clear();
                    }
                    else
                    {
                        for (int i = loot.Count - count; i < loot.Count; i++)
                        {
                            stolenLoot.Add(loot[i]);
                        }

                        loot.RemoveRange(loot.Count - count, count);
                        Console.WriteLine(string.Join(", ", stolenLoot));
                    }
                }

                command = Console.ReadLine();
            }

            if (loot.Any())
            {
                double sum = 0.0;
                foreach (var item in loot)
                {
                    sum += item.Length;
                }

                Console.WriteLine($"Average treasure gain: {sum / loot.Count:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
