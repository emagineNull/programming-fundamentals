using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            string[] command = Console.ReadLine().Split(' ');

            int element = 0;
            int position = 0;
            while (command[0] != "Odd" && command[0] != "Even")
            {
                if (command[0] == "Delete")
                {
                    element = int.Parse(command[1]);
                    sequence.RemoveAll(item => item == element);
                }
                else if (command[0] == "Insert")
                {
                    element = int.Parse(command[1]);
                    position = int.Parse(command[2]);
                    sequence.Insert(position, element);
                }

                Array.Clear(command, 0, command.Length);
                command = Console.ReadLine().Split(' ');
            }

            if (command[0] == "Even")
            {
                foreach (var num in sequence)
                {
                    if (num % 2 == 0)
                    {
                        Console.Write(num + " ");
                    }
                }
            }
            else
            {
                foreach (var num in sequence)
                {
                    if (num % 2 != 0)
                    {
                        Console.Write(num + " ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
