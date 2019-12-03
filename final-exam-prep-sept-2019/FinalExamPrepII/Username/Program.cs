using System;
using System.Linq;

namespace Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Sign up")
            {
                string[] commandParts = command.Split();
                if (commandParts[0] == "Case")
                {
                    if (commandParts[1] == "lower")
                    {
                        username = username.ToLower();
                    }
                    else if (commandParts[1] == "upper")
                    {
                        username = username.ToUpper();
                    }

                    Console.WriteLine(username);
                }
                else if (commandParts[0] == "Reverse")
                {
                    int startIndex = int.Parse(commandParts[1]);
                    int endIndex = int.Parse(commandParts[2]);

                    if (startIndex >= 0 && endIndex > startIndex && endIndex < username.Length)
                    {
                        string word = username.Substring(startIndex, (endIndex - startIndex) + 1);
                        Console.WriteLine(string.Join("", word.Reverse()));
                    }
                }
                else if (commandParts[0] == "Cut")
                {
                    string subStr = commandParts[1];

                    if (username.Contains(subStr))
                    {
                        int index = username.IndexOf(subStr);
                        username = username.Remove(index, subStr.Length);

                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {subStr}.");
                    }
                }
                else if (commandParts[0] == "Replace")
                {
                    string symbol = commandParts[1];
                    username = username.Replace(symbol, "*");

                    Console.WriteLine(username);
                }
                else if (commandParts[0] == "Check")
                {
                    char symbol = char.Parse(commandParts[1]);

                    if (!username.Contains(symbol))
                    {
                        Console.WriteLine($"Your username must contain {symbol}.");
                    }
                    else
                    {
                        Console.WriteLine("Valid");
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
