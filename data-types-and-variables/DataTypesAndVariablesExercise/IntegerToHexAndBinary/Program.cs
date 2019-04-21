using System;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(integer, 16);
            string bin = Convert.ToString(integer, 2);

            Console.WriteLine(hex.ToUpper());
            Console.WriteLine(bin);
        }
    }
}
