using System;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            if (thirdNum > GetMax(firstNum, secondNum))
            {
                Console.WriteLine(thirdNum);
            }
            else
            {
                Console.WriteLine(GetMax(firstNum, secondNum));
            }
        }

        static int GetMax(int firstNum, int secondNum)
        {
            return Math.Max(firstNum, secondNum);
        }
    }
}
