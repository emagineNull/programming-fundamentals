using System;
using System.Text;
using System.Numerics;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            Console.WriteLine(CharMultiplier(input[0], input[1]));
        }

        public static int CharMultiplier(string str1, string str2)
        {
            var result = 0;
            var length = 0;
            var end = 0;
            var longer = string.Empty;
            var start = 0;

            if (str1.Length != str2.Length)
            {
                length = str1.Length < str2.Length ? str1.Length : str2.Length;
            }
            else
            {
                length = str1.Length;
            }

            for (int i = 0; i < length; i++)
            {
                result += (str1[i] * str2[i]);
            }

            if (str1.Length > str2.Length)
            {
                end = str1.Length - str2.Length;
                start = str1.Length - (str1.Length - str2.Length);
                longer = str1.Substring(start);
            }
            else if (str1.Length < str2.Length)
            {
                end = str2.Length - str1.Length;
                start = str2.Length - (str2.Length - str1.Length);
                longer = str2.Substring(start);
            }

            if (str1.Length != str2.Length)
            {
                for (int i = 0; i < end; i++)
                {
                    result += longer[i];
                }
            }

            return result;
        }
    }
}
