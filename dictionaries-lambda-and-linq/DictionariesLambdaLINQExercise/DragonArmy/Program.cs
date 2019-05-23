using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, SortedDictionary<string, Dictionary<string, double>>>();
            var input = new string[n];

            var damage = 0.0;
            var health = 0.0;
            var armor = 0.0;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ').ToArray();

                try
                {
                    damage = double.Parse(input[2]);
                }
                catch
                {
                    damage = 45;
                }

                try
                {
                    health = double.Parse(input[3]);
                }
                catch
                {
                    health = 250;
                }

                try
                {
                    armor = double.Parse(input[4]);
                }
                catch
                {
                    armor = 10;
                }

                if (!dragons.ContainsKey(input[0]))
                {
                    dragons.Add(input[0], new SortedDictionary<string, Dictionary<string, double>>());
                }
                if (!dragons[input[0]].ContainsKey(input[1]))
                {
                    dragons[input[0]].Add(input[1], new Dictionary<string, double>());
                }
                if (dragons[input[0]].ContainsKey(input[1]))
                {
                    dragons[input[0]][input[1]]["damage"] = damage;
                    dragons[input[0]][input[1]]["health"] = health;
                    dragons[input[0]][input[1]]["armor"] = armor;
                }
            }

            var avgDmg = 0.0;
            var avgHp = 0.0;
            var avgArm = 0.0;

            foreach (var type in dragons)
            {
                foreach (var avg in type.Value)
                {
                    avgDmg += avg.Value["damage"];
                    avgHp += avg.Value["health"];
                    avgArm += avg.Value["armor"];
                }

                Console.WriteLine($"{type.Key}::({avgDmg / type.Value.Keys.Count:f2}/{avgHp / type.Value.Keys.Count:f2}/" +
                    $"{avgArm / type.Value.Keys.Count:f2})");

                foreach (var dragon in type.Value)
                {
                    Console.Write($"-{dragon.Key} -> damage: {dragon.Value["damage"]}, health: {dragon.Value["health"]}, " +
                        $"armor: {dragon.Value["armor"]}");
                    Console.WriteLine();
                }

                avgDmg = 0.0;
                avgHp = 0.0;
                avgArm = 0.0;
            }
        }
    }
}
