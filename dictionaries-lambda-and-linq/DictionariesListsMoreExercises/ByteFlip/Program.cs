using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Where(x => x.Length == 2).Reverse().ToList();

            for (int i = 0; i < input.Count; i++)
            {
                string reversedNum = new string(input[i].ToCharArray().Reverse().ToArray());
                input[i] = reversedNum;
            }
            
            for (int i = 0; i < input.Count; i++)
            {
                var hex = input[i];
                var value = Convert.ToInt32(hex, 16);

                Console.Write($"{(char)value}");
            }
        }
    }
}
