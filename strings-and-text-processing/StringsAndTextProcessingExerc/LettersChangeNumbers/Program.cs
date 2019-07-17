using System;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"{Sum(input):f2}");
        }

        public static double Sum(string[] input)
        {
            var total = 0.0;
            for (int i = 0; i < input.Length; i++)
            {
                var currentText = input[i];
                var currentNum = double.Parse(currentText.Substring(1, currentText.Length - 2));

                var firstLetter = currentText[0];
                var lastLetter = currentText[currentText.Length - 1];

                var upperCaseFirst = firstLetter - 64.0;
                var lowerCaseFirst = firstLetter - 96.0;
                var upperCaseLast = lastLetter - 64.0;
                var lowerCaseLast = lastLetter - 96.0;

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    total += currentNum / upperCaseFirst;
                }
                else
                {
                    total += currentNum * lowerCaseFirst;
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    total -= (lastLetter - 64);
                }
                else
                {
                    total += (lastLetter - 96);
                }
            }

            return total;
        }
    }
}
