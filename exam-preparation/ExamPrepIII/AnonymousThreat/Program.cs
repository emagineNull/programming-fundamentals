using System;
using System.Linq;
using System.Collections.Generic;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(' ').ToList();

            var commands = Console.ReadLine();

            while (commands != "3:1")
            {
                var currentCommand = commands.Split(' ');

                var command = currentCommand[0];

                if (command == "merge")
                {
                    var startIndex = int.Parse(currentCommand[1]);
                    var endIndex = int.Parse(currentCommand[2]);

                    if ((startIndex >= 0 || startIndex < data.Count) && (endIndex >= 0 || endIndex < data.Count))
                    {
                        var concat = string.Concat(data[startIndex], data[endIndex]);

                        data[startIndex] = concat;
                        data.RemoveAt(endIndex);
                    }
                }
                if (command == "divide")
                {
                    var index = int.Parse(currentCommand[1]);
                    var partitions = int.Parse(currentCommand[2]);
                    var divided = new List<string>();

                    if (data[index].Length % partitions == 0)
                    {
                        divided = Enumerable.Range(0, data[index].Length / partitions)
                                        .Select(i => data[index].Substring(i * partitions, partitions)).ToList();
                    }

                    data.RemoveAt(index);

                    for (int i = index; i < divided.Count; i++)
                    {
                        var dividedIndexes = divided.Count - 1;

                        data.AddRange(divided);
                    }
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", data));
        }
    }
}
