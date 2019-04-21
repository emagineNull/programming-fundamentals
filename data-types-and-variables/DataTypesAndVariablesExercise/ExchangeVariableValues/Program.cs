using System;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 10;
            var c = 0;

            c = b;
            b = a;
            a = c;

            Console.WriteLine($"Before: \na = 5\nb = 10\nAfter: \na = {a}\nb = {b}");
        }
    }
}
