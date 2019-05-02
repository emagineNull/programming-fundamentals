using System;
using System.Linq;

namespace SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int lengthArr = arr.Length;

            string[] command = Console.ReadLine().Split(' ');
            while (command[0] != "END")
            {
                string action = command[0];

                if (action == "Reverse")
                {
                    Array.Reverse(arr);
                }
                else if (action == "Distinct")
                {
                    arr = arr.Distinct().ToArray();
                    lengthArr = arr.Count(s => s != null);
                }
                else if (action == "Replace")
                {
                    if (int.Parse(command[1]) < 0 || int.Parse(command[1]) > lengthArr - 1)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        arr[int.Parse(command[1])] = command[2];
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
