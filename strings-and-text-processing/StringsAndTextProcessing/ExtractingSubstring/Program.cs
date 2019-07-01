using System;

namespace ExtractingSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            var someText = "Test Test Test";

            var test = someText.Substring(5, 6);

            Console.WriteLine(test);
        }
    }
}
