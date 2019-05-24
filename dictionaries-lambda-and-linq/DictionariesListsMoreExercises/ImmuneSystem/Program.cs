using System;
using System.Collections.Generic;
using System.Linq;

namespace ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var imuneSystemLog = new List<string>();
            var knownViruses = new List<string>();
            var initialHealth = int.Parse(Console.ReadLine());
            var currentHealth = initialHealth;

            var command = Console.ReadLine();

            while (command != "end" && currentHealth > 0)
            {
                var virusName = command;
                var virusStrength = command.Sum(x => x);
                virusStrength /= 3;
                var defeatTimeSeconds = virusStrength * virusName.Length;
                defeatTimeSeconds =
                    knownViruses.Contains(virusName) ?
                    defeatTimeSeconds / 3 :
                    defeatTimeSeconds;
                currentHealth -= defeatTimeSeconds;

                if (currentHealth <= 0)
                {
                    imuneSystemLog.Add($"Virus {virusName}: {virusStrength} => {defeatTimeSeconds} seconds");
                    continue;
                }

                var defeatTime = CalcDefeatTime(defeatTimeSeconds);

                knownViruses.Add(virusName);

                var result = $"Virus {virusName}: {virusStrength} => {defeatTimeSeconds} seconds\n";
                result += $"{virusName} defeated in {defeatTime}.\n";
                result += $"Remaining health: {currentHealth}";

                imuneSystemLog.Add(result);
                currentHealth =
                    (int)(currentHealth * 1.2) > initialHealth ?
                    initialHealth :
                    (int)(currentHealth * 1.2);
                command = Console.ReadLine();
            }

            foreach (var entry in imuneSystemLog)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine(
                currentHealth < 0 ?
                "Immune System Defeated." :
                $"Final Health: {currentHealth}");
        }

        static string CalcDefeatTime(int defeatTimeSeconds)
        {
            var result = (defeatTimeSeconds / 60) + "m ";
            result += (defeatTimeSeconds % 60) + "s";
            return result;
        }
    }
}
