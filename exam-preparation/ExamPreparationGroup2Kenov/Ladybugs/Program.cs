using System;
using System.Linq;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeOfField = int.Parse(Console.ReadLine());
            var field = new int[sizeOfField];
            var indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] < field.Length && indexes[i] >= 0)
                {
                    field[indexes[i]] = 1;
                }
            }

            var command = Console.ReadLine();

            var commandCounter = 1;

            while (command != "end")
            {
                if (commandCounter > 100)
                {
                    break;
                }
                var commandAsArr = command.Split(' ');

                var startIndex = int.Parse(commandAsArr[0]);
                var direction = commandAsArr[1];
                var flightLength = int.Parse(commandAsArr[2]);

                if (flightLength < 0)
                {
                    if (direction == "left")
                    {
                        direction = "right";
                        flightLength = Math.Abs(flightLength);
                    }
                    else if (direction == "right")
                    {
                        direction = "left";
                        flightLength = Math.Abs(flightLength);
                    }
                }

                if (startIndex < 0 || startIndex > field.Length - 1 || field[startIndex] == 0 || flightLength == 0)
                {
                    command = Console.ReadLine();
                    commandCounter++;
                    continue;
                }

                if (flightLength > field.Length - 1 && direction == "right")
                {
                    command = Console.ReadLine();
                    commandCounter++;
                    field[startIndex] = 0;
                    continue;
                }

                if (flightLength + startIndex > field.Length - 1 && direction == "right")
                {
                    command = Console.ReadLine();
                    commandCounter++;
                    field[startIndex] = 0;
                    continue;
                }

                if (startIndex - flightLength < 0 && direction == "left")
                {
                    command = Console.ReadLine();
                    commandCounter++;
                    field[startIndex] = 0;
                    continue;
                }

                if (direction == "right")
                {
                    field[startIndex] = 0;
                    var endIndex = startIndex + flightLength;
                    while (true)
                    {
                        if (endIndex > field.Length - 1)
                        {
                            break;
                        }
                        if (field[endIndex] == 1)
                        {
                            endIndex++;
                            //try
                            //{
                            //    field[endIndex] = 1;
                            //}
                            //catch
                            //{
                            //    field[sizeOfField] = 0;
                            //}
                        }
                        else if (field[endIndex] == 0)
                        {
                            field[endIndex] = 1;
                            break;
                        }
                    }
                }
                if (direction == "left")
                {
                    field[startIndex] = 0;
                    var endIndex = startIndex - flightLength;
                    while (true)
                    {
                        if (endIndex < 0)
                        {
                            break;
                        }
                        if (field[endIndex] == 1)
                        {
                            endIndex--;
                        }
                        else if (field[endIndex] == 0)
                        {
                            field[endIndex] = 1;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
                commandCounter++;
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
