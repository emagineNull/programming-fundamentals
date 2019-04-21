using System;

namespace VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hex, 16));
        }
    }
}
