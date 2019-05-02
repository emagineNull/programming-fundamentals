using System;
using System.Linq;

namespace ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());

            string command = string.Empty;
            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine();
                if (command == "Reverse")
                {
                    Array.Reverse(arr);
                }
                else if (command == "Distinct")
                {
                    arr = arr.Distinct().ToArray();
                }
                else
                {
                    string[] replace = command.Split(' ').ToArray();
                    arr[int.Parse(replace[1])] = replace[2];
                }
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
