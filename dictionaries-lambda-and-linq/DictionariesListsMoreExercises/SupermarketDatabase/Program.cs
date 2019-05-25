using System;
using System.Collections.Generic;
using System.Linq;

namespace SupermarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, List<double>>();
            var current = Console.ReadLine().Split().ToList();

            while (current[0] != "stocked")
            {
                var name = current[0];
                var price = double.Parse(current[1]);
                var quantity = int.Parse(current[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new List<double>());
                    products[name].Add(0);
                    products[name].Add(0);
                }
                products[name][0] = price;
                products[name][1] += quantity;

                current = Console.ReadLine().Split().ToList();
            }

            double totalPrice = 0;

            foreach (var product in products)
            {
                var price = product.Value[0] * product.Value[1];
                Console.WriteLine($"{product.Key}: ${product.Value[0]:f2} * {product.Value[1]} = ${price:f2}");
                totalPrice += price;
            }

            Console.WriteLine("{0}", string.Concat(Enumerable.Repeat("-", 30)));
            Console.WriteLine($"Grand Total: ${totalPrice:f2}");
        }
    }
}
