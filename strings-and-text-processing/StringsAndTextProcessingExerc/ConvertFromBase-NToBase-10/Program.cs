using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConvertFromBase_NToBase_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            BigInteger result = 0;

            var baseN = int.Parse(input[0]);
            var num = input[1].ToCharArray();

            for (int i = 0; i < num.Length; i++)
            {
                var currentDigitAsString = num[num.Length - i - 1].ToString();
                var currentDigit = int.Parse(currentDigitAsString);

                var toThePow = BigInteger.Pow(baseN, i);
                result = result + (currentDigit * toThePow);
            }

            Console.WriteLine(result);
        }
    }
}
