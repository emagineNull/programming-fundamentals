using System;

namespace EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();

            LastDigit(n);
        }

        static void LastDigit(string number)
        {
            if (number.EndsWith("9"))
            {
                Console.WriteLine("nine");
            }
            else if (number.EndsWith("8"))
            {
                Console.WriteLine("eight");
            }
            else if (number.EndsWith("7"))
            {
                Console.WriteLine("seven");
            }
            else if (number.EndsWith("6"))
            {
                Console.WriteLine("six");
            }
            else if (number.EndsWith("5"))
            {
                Console.WriteLine("five");
            }
            else if (number.EndsWith("4"))
            {
                Console.WriteLine("four");
            }
            else if (number.EndsWith("3"))
            {
                Console.WriteLine("three");
            }
            else if (number.EndsWith("2"))
            {
                Console.WriteLine("two");
            }
            else if (number.EndsWith("1"))
            {
                Console.WriteLine("one");
            }
            else if (number.EndsWith("0"))
            {
                Console.WriteLine("zero");
            }
        }
    }
}
