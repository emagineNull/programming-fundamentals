using System;
using System.Collections.Generic;
using System.Linq;

namespace ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] piratesInput = Console.ReadLine().Split('>').Select(int.Parse).ToArray();
            int[] warShipInput = Console.ReadLine().Split('>').Select(int.Parse).ToArray();
            int maxHealth = int.Parse(Console.ReadLine());

            var pirateShip = new List<int>(piratesInput);
            var warShip = new List<int>(warShipInput);

            string command = Console.ReadLine();

            while (command != "Retire")
            {
                string[] commandParts = command.Split();

                string action = commandParts[0];

                if (action == "Fire")
                {
                    int index = int.Parse(commandParts[1]);

                    if (index >= 0 && index < warShip.Count)
                    {
                        int damage = int.Parse(commandParts[2]);

                        if (warShip[index] - damage <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }

                        warShip[index] -= damage;
                    }
                }
                else if (action == "Defend")
                {
                    int startIndex = int.Parse(commandParts[1]);
                    int endIndex = int.Parse(commandParts[2]);

                    if (startIndex >= 0 && startIndex < pirateShip.Count &&
                        endIndex >= 0 && endIndex < pirateShip.Count && startIndex < endIndex)
                    {
                        int damage = int.Parse(commandParts[3]);
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            if (pirateShip[i] - damage <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }

                            pirateShip[i] -= damage;
                        }
                    }
                }
                else if (action == "Repair")
                {
                    int index = int.Parse(commandParts[1]);

                    if (index >= 0 && index < pirateShip.Count)
                    {
                        int health = int.Parse(commandParts[2]);

                        if (pirateShip[index] + health > maxHealth)
                        {
                            pirateShip[index] = maxHealth;
                        }
                        else
                        {
                            pirateShip[index] += health;
                        }
                    }
                }
                else if (action == "Status")
                {
                    int counter = 0;
                    double needRepair = maxHealth * 0.2;

                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < needRepair)
                        {
                            counter++;
                        }
                    }

                    Console.WriteLine($"{counter} sections need repair.");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}
