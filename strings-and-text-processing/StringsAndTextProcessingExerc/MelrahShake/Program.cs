using System;

namespace MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var pattern = Console.ReadLine();

            Console.WriteLine(Shaker(str, pattern));
        }

        public static string Shaker(string str, string pattern)
        {
            while (str.Length > 0 && pattern.Length > 0)
            {
                var firstIndex = str.IndexOf(pattern);
                var lastIndex = str.LastIndexOf(pattern);

                if (str.Contains(pattern) && firstIndex >= 0 && lastIndex >= 0 && firstIndex != lastIndex)
                {
                    str = str.Remove(firstIndex, pattern.Length);
                    lastIndex = str.LastIndexOf(pattern);
                    str = str.Remove(lastIndex, pattern.Length);

                    pattern = pattern.Remove(pattern.Length / 2, 1);

                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("No shake.");
            return str;
        }
    }
}
