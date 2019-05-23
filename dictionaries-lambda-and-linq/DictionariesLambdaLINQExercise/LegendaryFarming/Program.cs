using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            SortedDictionary<string, int> materials = new SortedDictionary<string, int>();

            materials["shards"] = 0;
            materials["fragments"] = 0;
            materials["motes"] = 0;

            bool enoughShards = false;
            bool enoughFragments = false;
            bool enoughMotes = false;

            while (enoughShards == false && enoughFragments == false && enoughMotes == false)
            {
                input = Console.ReadLine().Split(' ').ToList();

                for (int i = 0; i < input.Count; i+=2)
                {
                    if (!materials.ContainsKey(input[i + 1].ToLower()))
                    {
                        materials.Add(input[i + 1].ToLower(), int.Parse(input[i]));
                    }
                    else
                    {
                        materials[input[i + 1].ToLower()] += int.Parse(input[i]);
                    }

                    if (materials.ContainsKey("fragments"))
                    {
                        if (materials["fragments"] >= 250)
                        {
                            enoughFragments = true;
                            break;
                        }
                    }
                    if (materials.ContainsKey("shards"))
                    {
                        if (materials["shards"] >= 250)
                        {
                            enoughShards = true;
                            break;
                        }
                    }
                    if (materials.ContainsKey("motes"))
                    {
                        if (materials["motes"] >= 250)
                        {
                            enoughMotes = true;
                            break;
                        }
                    }
                }
            }

            if (enoughShards == true)
            {
                materials["shards"] -= 250;
                Console.WriteLine("Shadowmourne obtained!");
            }

            if (enoughFragments == true)
            {
                materials["fragments"] -= 250;
                Console.WriteLine("Valanyr obtained!");
            }
            
            if (enoughMotes == true)
            {
                materials["motes"] -= 250;
                Console.WriteLine("Dragonwrath obtained!");
            }

            foreach (var keyMat in materials.OrderByDescending(x => x.Value))
            {
                if (keyMat.Key == "shards" || keyMat.Key == "fragments" || keyMat.Key == "motes")
                {
                    Console.WriteLine(keyMat.Key + ": " + keyMat.Value);
                }
            }

            foreach (var leftMat in materials)
            {
                if (leftMat.Key != "shards" && leftMat.Key != "fragments" && leftMat.Key != "motes")
                {
                    Console.WriteLine(leftMat.Key + ": " + leftMat.Value);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
