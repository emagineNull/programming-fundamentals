using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var command = input[0];
                var username = input[1];

                if (command == "unregister")
                {
                    if (!parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parking.Remove(username);
                        Console.WriteLine($"user {username} unregistered successfully");
                    }
                }
                else if (command == "register" && input.Length < 3)
                {
                    continue;
                }
                else if (command == "register")
                {
                    var licensePlate = input[2].ToCharArray();
                    var licensePlateAsString = string.Empty;

                    for (int j = 0; j < licensePlate.Length; j++)
                    {
                        licensePlateAsString += licensePlate[j];
                    }

                    if (licensePlate.Length != 8)
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licensePlateAsString}");
                        continue;
                    }

                    var isLetter = Char.IsLetter(licensePlate[0]) && Char.IsLetter(licensePlate[1]) && Char.IsLetter(licensePlate[6])
                        && Char.IsLetter(licensePlate[7]);
                    var isDigit = Char.IsDigit(licensePlate[2]) && Char.IsDigit(licensePlate[3]) && Char.IsDigit(licensePlate[4]) &&
                        Char.IsDigit(licensePlate[5]);
                    var licenseIsValid = false;

                    if (isLetter && isDigit && licensePlate.Length == 8)
                    {
                        var isUpper = Char.IsUpper(licensePlate[0]) && Char.IsUpper(licensePlate[1]) && Char.IsUpper(licensePlate[6]) &&
                            Char.IsUpper(licensePlate[7]);
                        if (isUpper)
                        {
                            licenseIsValid = true;
                        }
                    }

                    if (parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
                    }
                    else if (!parking.ContainsKey(username))
                    {
                        if (!licenseIsValid)
                        {
                            Console.WriteLine($"ERROR: invalid license plate {licensePlateAsString}");
                            continue;
                        }
                        if (parking.ContainsValue(licensePlateAsString))
                        {
                            Console.WriteLine($"ERROR: license plate {licensePlateAsString} is busy");
                            continue;
                        }
                        parking.Add(username, licensePlateAsString);
                        Console.WriteLine($"{username} registered {licensePlateAsString} successfully");
                    }
                }
            }

            foreach (var print in parking)
            {
                Console.WriteLine($"{print.Key} => {print.Value}");
            }
        }
    }
}
