using System;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long price1 = long.Parse(Console.ReadLine());
            long price2 = long.Parse(Console.ReadLine());
            long totalPrice = 0;

            if (price1 > sbyte.MaxValue)
            {
                totalPrice = price1 * 10 + price2 * 4;
            }
            else if (price2 > sbyte.MaxValue)
            {
                totalPrice = price2 * 10 + price1 * 4;
            }

            Console.WriteLine(totalPrice);
        }
    }
}
