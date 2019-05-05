using System;
using System.Collections.Generic;
using System.Linq;

namespace PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "END")
            {
                if (command[0] == "A")
                {
                    phonebook[command[1]] = command[2];
                }
                else if (command[0] == "S")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"{command[1]} -> {phonebook[command[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                    }
                }
                else
                {
                    foreach (var name in phonebook)
                    {
                        Console.WriteLine($"{name.Key} -> {name.Value}");
                    }
                }

                command = Console.ReadLine().Split(' ');
            }
        }
    }
}
