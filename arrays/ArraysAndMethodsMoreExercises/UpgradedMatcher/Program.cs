using System;
using System.Linq;

namespace UpgradedMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ');
            long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            Array.Resize(ref quantities, products.Length);

            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "done")
            {
                string productName = command[0];
                long quantity = long.Parse(command[1]);
                if (Array.IndexOf(products, productName) >= quantities.Length)
                {
                    Console.WriteLine($"We do not have enough {productName}");
                }
                else if (quantities[Array.IndexOf(products, productName)] - quantity < 0)
                {
                    Console.WriteLine($"We do not have enough {productName}");
                }
                else
                {
                    Console.WriteLine($"{productName} x {quantity} costs {price[Array.IndexOf(products, productName)] * quantity:f2}");
                    quantities[Array.IndexOf(products, productName)] -= quantity;
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
