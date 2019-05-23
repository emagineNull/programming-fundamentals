using System;
using System.Collections.Generic;
using System.Linq;

namespace SrubskoUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var srubskoto = new Dictionary<string, Dictionary<string, long>>();

            var flag = false;
            var flag2 = false;
            var total = 0L;
            var singerName = " ";
            var venueName = " ";
            var counterSinger = 0;
            var counterVenue = 0;

            while (input[0] != "End")
            {
                var firstWord = input[0].ToCharArray();
                if (firstWord[0] == '@' || input.Length < 4 || input.Length > 8)
                {
                    input = Console.ReadLine().Split();
                    continue;
                }

                for (int i = 0; i < input.Length - 2; i++)
                {
                    char[] currentWord = input[i].ToCharArray();
                    if (currentWord[0] != '@' && flag == false)
                    {
                        if (counterSinger >= 3)
                        {
                            flag2 = true;
                            break;
                        }
                        singerName += input[i];
                        singerName += " ";
                        counterSinger++;
                    }
                    else
                    {
                        if (counterVenue >= 3)
                        {
                            flag2 = true;
                            break;
                        }
                        venueName += input[i];
                        venueName += " ";
                        counterVenue++;
                        flag = true;
                    }
                }

                if (flag == false || flag2 == true)
                {
                    singerName = " ";
                    venueName = " ";
                    counterSinger = 0;
                    counterVenue = 0;
                    flag2 = false;
                    input = Console.ReadLine().Split();
                    continue;
                }

                try
                {
                    total = long.Parse(input[input.Length - 2]) * long.Parse(input[input.Length - 1]);
                }
                catch
                {
                    singerName = " ";
                    venueName = " ";
                    counterSinger = 0;
                    counterVenue = 0;
                    input = Console.ReadLine().Split();
                    flag = false;
                    continue;
                }
                
                if (srubskoto.ContainsKey(venueName.Trim()))
                {
                    if (srubskoto[venueName.Trim()].ContainsKey(singerName.Trim()))
                    {
                        srubskoto[venueName.Trim()][singerName.Trim()] += total;
                    }
                    else
                    {
                        srubskoto[venueName.Trim()].Add(singerName.Trim(), total);
                    }
                }
                else
                {
                    srubskoto.Add(venueName.Trim(), new Dictionary<string, long>());
                    srubskoto[venueName.Trim()].Add(singerName.Trim(), total);
                }

                flag = false;
                flag2 = false;
                singerName = " ";
                venueName = " ";
                counterSinger = 0;
                counterVenue = 0;

                input = Console.ReadLine().Split();
            }

            foreach (var kvp in srubskoto)
            {
                Console.WriteLine($"{kvp.Key.Remove(0, 1)}");
                foreach (var party in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {party.Key} -> {party.Value}");
                }
            }
        }
    }
}
