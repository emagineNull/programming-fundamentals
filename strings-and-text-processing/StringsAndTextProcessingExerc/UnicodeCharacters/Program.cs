using System;
using System.Text;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            foreach (var c in text)
            {
                sb.Append("\\u");
                sb.Append(String.Format($"{((int)c):x4}"));
            }
            
            Console.WriteLine(sb.ToString());
        }
    }
}
