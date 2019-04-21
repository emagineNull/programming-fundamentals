using System;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());

            if (number < number2)
            {
                for (int i = number; i <= number2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = number2; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
