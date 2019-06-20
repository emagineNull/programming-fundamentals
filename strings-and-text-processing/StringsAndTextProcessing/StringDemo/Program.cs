using System;
using System.Collections.Generic;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello";

            // text[1] = '5'; <- immutable, it is not changeable, strings are read only => Error!

            Console.WriteLine(text[1]);

            var str = new string(new char[] { 's', 't', 'r' });
            var text2 = new string('a', 5);

            Console.WriteLine(text2);

            bool areEqual = "text" == "text"; // comapares every character, characters => ASCII => numbers => bits (0 and 1), pobitovi operacii

            string.Compare("test", "test");
            string.Compare("test", "test", false); // the same as the upper, case-sensitive

            var result = string.Concat("First", "Second", "Third");

            Console.WriteLine(result);

            var result2 = "String" + 1 + 2;

            var list = new List<int> { 3, 4, 5 };

            var result3 = "Some Nums" + 1 + 2 + string.Join(',', list);

            Console.WriteLine(result3);

            string email = "vasko@gmail.com";

            var indexOfKliomba = email.IndexOf('@');
            var indexOfVasko = email.IndexOf("vasko");
            var notFound = email.IndexOf("notFound");
            var firstIndexOfA = email.IndexOf('a');
            var lastIndexOfA = email.LastIndexOf('a');

            Console.WriteLine(indexOfKliomba);
            Console.WriteLine(indexOfVasko);
            Console.WriteLine(notFound);
            Console.WriteLine(firstIndexOfA);
            Console.WriteLine(lastIndexOfA);
        }
    }
}
