using System;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var charArr = text.ToCharArray();
            Array.Reverse(charArr);

            Console.WriteLine(string.Join(string.Empty, charArr));
        }
    }
}
