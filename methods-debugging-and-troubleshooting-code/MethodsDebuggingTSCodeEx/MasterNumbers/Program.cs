using System;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());

            Finder(endNum);
        }

        static void Finder(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                if (IsPalindrome(i))
                {
                    if (SumDigits(i) && ContainsEvenDigit(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        static bool IsPalindrome(int num)
        {
            string numPal = num.ToString();
            char[] charArray = numPal.ToCharArray();
            Array.Reverse(charArray);
            return numPal.Equals(new string(charArray));
        }

        static bool SumDigits(int num)
        {
            var sum = 0;
            while (num > 0)
            {
                var currentDigit = num % 10;

                sum += currentDigit;
                num /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ContainsEvenDigit(int num)
        {
            while (num > 0)
            {
                var currentDigit = num % 10;

                if (currentDigit % 2 == 0)
                {
                    return true;
                }

                num /= 10;
            }

            return false;
        }
    }
}
