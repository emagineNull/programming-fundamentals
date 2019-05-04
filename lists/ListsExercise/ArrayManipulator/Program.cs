using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int listLength = sequence.Count;

            string[] command = Console.ReadLine().Split(' ');

            int index = 0;
            int element = 0;
            while (command[0] != "print")
            {
                if (command[0] == "add")
                {
                    index = int.Parse(command[1]);
                    element = int.Parse(command[2]);
                    sequence.Insert(index, element);
                    listLength = sequence.Count;
                }
                else if (command[0] == "addMany")
                {
                    index = int.Parse(command[1]);

                    List<int> listToAdd = new List<int>();

                    for (int i = 2; i < command.Length; i++)
                    {
                        listToAdd.Add(int.Parse(command[i]));
                    }

                    sequence.InsertRange(index, listToAdd);
                    listLength = sequence.Count;
                }
                else if (command[0] == "contains")
                {
                    element = int.Parse(command[1]);
                    if (sequence.Contains(element))
                    {
                        index = sequence.IndexOf(element);
                        Console.WriteLine(index);
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (command[0] == "remove")
                {
                    index = int.Parse(command[1]);
                    sequence.RemoveAt(index);
                    listLength--;
                }
                else if (command[0] == "shift")
                {
                    index = int.Parse(command[1]);
                    if (index == 1)
                    {
                        element = sequence[0];
                        sequence.RemoveAt(0);
                        sequence.Add(element);
                    }
                    else
                    {
                        for (int i = 0; i < index; i++)
                        {
                            element = sequence[0];
                            sequence.RemoveAt(0);
                            sequence.Add(element);
                        }
                    }
                }
                else if (command[0] == "sumPairs")
                {
                    for (int i = 0; i < listLength / 2; i++)
                    {
                        int pairSum = sequence[i] + sequence[i + 1];
                        sequence.Insert(i, pairSum);
                        sequence.RemoveAt(i + 1);
                        sequence.RemoveAt(i + 1);
                    }

                    listLength = sequence.Count;
                }

                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine($"[{string.Join(", ", sequence)}]");
        }
    }
}
