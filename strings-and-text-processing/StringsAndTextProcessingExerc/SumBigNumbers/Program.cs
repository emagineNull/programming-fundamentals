using System;
using System.Collections.Generic;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = Console.ReadLine();
            var secondNumber = Console.ReadLine();

            Console.WriteLine(Sum(firstNumber, secondNumber));
        }

        public static string Sum(string str1, string str2)
        {
            str1 = str1.TrimStart('0');
            str2 = str2.TrimStart('0');
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
                    firstNumList.Insert(0, 0);
                }

                try
                {
                    secondNumList.Add(int.Parse(str2[i].ToString()));
                }
                catch
                {
                    secondNumList.Insert(0, 0);
                }
            }

            //if (str1.Length < str2.Length)
            //{
            //    firstNumList.Reverse();
            //}
            //else if (str1.Length > str2.Length)
            //{
            //    secondNumList.Reverse();
            //}

            var result = new List<string>();
            var currentDigitsSum = 0;
            var temp = 0;
            //var shorterLength = str1.Length > str2.Length ? str2.Length : str1.Length;
            //var index = length - 1;


            for (int i = length - 1; i >= 0; i--)
            {
                //try
                //{
                    currentDigitsSum = firstNumList[i] + secondNumList[i] + temp;
                //}
                //catch
                //{
                //    if (str1.Length > str2.Length && index >= 0)
                //    {
                //        currentDigitsSum = firstNumList[index] + temp;
                //    }
                //    else if (str1.Length < str2.Length && index >= 0)
                //    {
                //        currentDigitsSum = secondNumList[index] + temp;
                //    }
                //    else
                //    {
                //        currentDigitsSum += temp;
                //    }
                //}

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

            if (temp == 1)
            {
                result.Add("1");
            }

            result.Reverse();

            return string.Join("", result);
        }
    }
}
