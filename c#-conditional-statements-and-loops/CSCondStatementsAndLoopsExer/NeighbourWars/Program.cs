using System;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());
            var round = 0;
            var winner = string.Empty;
            var peshoHealth = 100;
            var goshoHealth = 100;

            while (true)
            {
                if (peshoHealth > 0 && goshoHealth > 0)
                {
                    round++;
                }
                if (round % 2 == 0)
                {
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        return;
                    }
                    peshoHealth -= goshoDamage;
                    if (peshoHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                    }
                }
                else if (round % 2 != 0)
                {
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        return;
                    }
                    goshoHealth -= peshoDamage;
                    if (goshoHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    }
                }

                if (round % 3 == 0 && peshoHealth > 0 && goshoHealth > 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
        }
    }
}
