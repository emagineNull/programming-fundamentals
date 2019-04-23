using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            Console.WriteLine(Power(number, power));
        }

        static double Power(double number, int power)
        {
            var result = 1.0;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
