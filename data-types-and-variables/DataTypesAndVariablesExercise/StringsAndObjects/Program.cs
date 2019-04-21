using System;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";

            string concatenated = String.Concat(hello, " ", world);
            Console.WriteLine(concatenated);
        }
    }
}
