using System;
using System.Linq;

namespace InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ');
            long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            string command = Console.ReadLine();

            while (command != "done")
            {
                Console.WriteLine($"{command} costs: {price[Array.IndexOf(products, command)]}; " +
                    $"Available quantity: {quantities[Array.IndexOf(products, command)]}");

                command = Console.ReadLine();
            }
        }
    }
}
