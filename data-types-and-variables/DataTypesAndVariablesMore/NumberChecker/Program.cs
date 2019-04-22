using System;

namespace NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            if (number - Math.Floor(number) > 0)
            {
                Console.WriteLine("floating-point");
            }
            else
            {
                Console.WriteLine("integer");
            }
        }
    }
}
