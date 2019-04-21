using System;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char miss = char.Parse(Console.ReadLine());

            for (char i = first; i <= second; i++)
            {
                for (char k = first; k <= second; k++)
                {
                    for (char l = first; l <= second; l++)
                    {
                        if (l == miss || k == miss || i == miss)
                        {
                            continue;
                        }
                        Console.Write($"{i}{k}{l} ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
