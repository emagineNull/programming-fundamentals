using System;
using System.Collections.Generic;
using System.Linq;

namespace SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> times = Console.ReadLine().Split().OrderBy(t => t).ToList();

            Console.WriteLine("{0}", string.Join(", ", times));
        }
    }
}
