using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

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

            var text5 = "Test Ivan Pesho Gosho";

            var result4 = text5.Replace("es", "BLA");
            text5 = text5.Replace("es", "BLA");

            Console.WriteLine(result4);
            Console.WriteLine(text5);

            text5 = text5.Remove(10, 2);

            Console.WriteLine(text5);

            var text6 = "Ivan Pesho Gosho";

            Console.WriteLine(text6.ToLower());
            Console.WriteLine(text6.ToUpper());

            var text7 = "         asdasd sa       dfd      ";

            Console.WriteLine(text7.Trim());
            Console.WriteLine(text7.TrimStart());
            Console.WriteLine(text7.TrimEnd());

            var text8 = "        aaaa   dfsdf gfg fgf aaaaaaaa";

            Console.WriteLine(text8.TrimEnd('a', ' '));
            Console.WriteLine(text8.TrimStart('a', ' '));
            Console.WriteLine(text8.Trim('a', ' '));

            var adder = "a";

            var stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                adder += "a";
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed);

            stopwatch = Stopwatch.StartNew();

            var adderWithSb = new StringBuilder();

            for (int i = 0; i < 100000; i++)
            {
                adderWithSb.Append("a");
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed);

            var endResult = adderWithSb.ToString();

            var sb = new StringBuilder();

            sb.Append(true);
            sb.Append(100);
            sb.AppendLine("text");
            sb.AppendLine();
            sb.Append(new List<int>());
            sb.AppendLine("Text");

            var resultSb = sb.ToString();

            Console.WriteLine(resultSb);

            var sb2 = new StringBuilder();

            sb2.Append("Ivan");
            sb2[1] = 'a';

            Console.WriteLine(sb2.ToString());

            // a
            // aa
            // aaa
            // aaaa
            // 10000

            var addSb = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                // Console.WriteLine(new string('a', 1)); <--- Slower
                addSb.AppendLine(new string('a', i));
            }

            Console.WriteLine(addSb.ToString());

            var decSb = new StringBuilder();

            decSb.Append("Ivan");
            decSb.Append("Gosho");

            decSb.Length--;

            Console.WriteLine(decSb.Length);

            Console.WriteLine(decSb.ToString());


        }
    }
}
