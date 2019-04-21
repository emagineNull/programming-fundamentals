using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int charIndex1 = int.Parse(Console.ReadLine());
            int charIndex2 = int.Parse(Console.ReadLine());

            for (char i = (char)charIndex1; i <= charIndex2; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
