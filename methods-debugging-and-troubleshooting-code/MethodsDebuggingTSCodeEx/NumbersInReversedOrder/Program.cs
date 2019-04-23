using System;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            ReverseNumber(number);
        }

        static void ReverseNumber(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
        }
    }
}
