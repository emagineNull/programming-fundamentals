using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var demonBook = new Dictionary<string, Dictionary<int, double>>();

            for (int i = 0; i < input.Length; i++)
            {
                demonBook.Add(input[i], new Dictionary<int, double>());
            }

            var demonHealthRegEx = @"[0-9]|[+\-*/]|\.";
            var demonDamageRegEx = @"[-+]?([0-9]*\.[0-9]+|[0-9]+)";
            var demonDamageOtherRegEx = @"([/\*])";

            for (int i = 0; i < demonBook.Count; i++)
            {
                var sumHealth = 0;
                var sumDamage = 0.0;
                var demon = input[i];
                var demonReplacedHealth = Regex.Replace(demon, demonHealthRegEx, "");
                var demonReplacedDamageNums = Regex.Matches(demon, demonDamageRegEx);
                var damageAsArr = demonReplacedDamageNums
                                   .Cast<Match>()
                                   .Select(a => double.Parse(a.Value))
                                   .ToArray();
                var demonReplacedDamageOther = Regex.Matches(demon, demonDamageOtherRegEx);
                var demonOtherAsArr = demonReplacedDamageOther
                                      .Cast<Match>()
                                      .Select(a => a.Value)
                                      .ToArray();
                for (int j = 0; j < demonReplacedHealth.Length; j++)
                {
                    sumHealth += demonReplacedHealth[j];
                }
                for (int j = 0; j < damageAsArr.Length; j++)
                {
                    sumDamage += damageAsArr[j];
                }
                for (int j = 0; j < demonOtherAsArr.Length; j++)
                {
                    if (demonOtherAsArr[j] == "/")
                    {
                        sumDamage /= 2;
                    }
                    else if (demonOtherAsArr[j] == "*")
                    {
                        sumDamage *= 2;
                    }
                }
                demonBook[demon].Add(sumHealth, sumDamage);
            }

            foreach (var demon in demonBook.OrderBy(a => a.Key))
            {
                Console.Write(demon.Key + " - ");
                foreach (var healthAndDmg in demon.Value)
                {
                    Console.WriteLine($"{healthAndDmg.Key} health, {healthAndDmg.Value:f2} damage");
                }
            }
        }
    }
}
