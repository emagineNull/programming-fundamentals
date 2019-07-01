using System;
using System.Diagnostics;
using System.Text;

namespace StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();

            timer.Start();

            var result = new StringBuilder();

            for (int i = 0; i < 50000; i++)
            {
                result.Append(Convert.ToString(i, 2));
            }

            Console.WriteLine(result.Length);
            Console.WriteLine(timer.Elapsed);
        }
    }
}
