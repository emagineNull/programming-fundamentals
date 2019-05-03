using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('|').ToList();
            items.Reverse();

            var appended = new List<string>();
            foreach (var item in items)
            {
                List<string> numbers = item.Split(' ').ToList();
                foreach (var number in numbers)
                {
                    if (number != "")
                    {
                        appended.Add(number);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", appended));
        }
    }
}
