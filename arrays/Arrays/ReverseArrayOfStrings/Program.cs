using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine().Split(' ');

            texts = texts.Reverse().ToArray();

            foreach (var text in texts)
            {
                Console.WriteLine(text);
            }
        }
    }
}
