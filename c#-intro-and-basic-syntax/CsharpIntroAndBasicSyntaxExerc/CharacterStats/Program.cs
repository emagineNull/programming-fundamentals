using System;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            if (true)
            {
                
            }
            Console.WriteLine($"Name: {name}\nHealth: {new string('|', currentHealth)}|" +
                $"{new string('.', maxHealth - currentHealth)}|\nEnergy: {new string('|', currentEnergy)}|" +
                $"{new string('.', maxEnergy - currentEnergy)}|");
        }
    }
}
