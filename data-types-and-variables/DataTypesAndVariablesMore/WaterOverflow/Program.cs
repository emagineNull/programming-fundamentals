using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            byte liters = 0;
            byte sum = 0;

            for (int i = 1; i <= n; i++)
            {
                try
                {
                    liters = byte.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Insufficient capacity!");
                }

                if (sum + liters <= 255)
                {
                    sum += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(sum);
        }
    }
}
