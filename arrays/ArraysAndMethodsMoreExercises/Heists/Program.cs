using System;
using System.Linq;

namespace Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceOfGoodies = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int jewels = 0;
            int gold = 0;
            long expenses = 0;

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "Jail" && command[1] != "Time")
            {
                char[] loot = command[0].ToCharArray();
                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '%')
                    {
                        jewels += priceOfGoodies[0];
                    }
                    if (loot[i] == '$')
                    {
                        gold += priceOfGoodies[1];
                    }
                }

                expenses += int.Parse(command[1]);

                command = Console.ReadLine().Split(' ').ToArray();
            }

            long totalEarnings = jewels + gold;

            if (totalEarnings >= expenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings - expenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {expenses - totalEarnings}.");
            }
        }
    }
}
