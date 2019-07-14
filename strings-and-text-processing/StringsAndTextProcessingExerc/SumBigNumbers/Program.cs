using System;
using System.Collections.Generic;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var firstNumber = input[0];
            var secondNumber = input[1];

            Console.WriteLine(Sum(firstNumber, secondNumber));
        }

        public static string Sum(string str1, string str2)
        {
            var length = str1.Length > str2.Length ? str1.Length : str2.Length;
            var firstNumList = new List<int>();
            var secondNumList = new List<int>();

            for (int i = 0; i < length; i++)
            {
                try
                {
                    firstNumList.Add(int.Parse(str1[i].ToString()));
                }
                catch
                {
                    firstNumList.Add(0);
                }

                try
                {
                    secondNumList.Add(int.Parse(str2[i].ToString()));
                }
                catch
                {
                    secondNumList.Add(0);
                }
            }

            if (str1.Length < str2.Length)
            {
                firstNumList.Reverse();
            }
            else if (str1.Length > str2.Length)
            {
                secondNumList.Reverse();
            }

            var result = new List<string>();
            var temp = 0;

            for (int i = length - 1; i >= 0; i--)
            {
                var currentDigitsSum = firstNumList[i] + secondNumList[i];
                var currentDigitsSumAsText = string.Empty;
                if (temp == 1)
                {
                    currentDigitsSum++;
                }
                if (currentDigitsSum > 9)
                {
                    temp = 1;
                    currentDigitsSum -= 10;
                }
                else
                {
                    temp = 0;
                }

                result.Add(currentDigitsSum.ToString());
            }
            


            return string.Join("", result);
        }
    }
}
