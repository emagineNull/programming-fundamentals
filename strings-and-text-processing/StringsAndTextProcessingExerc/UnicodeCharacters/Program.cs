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
                sb.Append(String.Format("{0:x4}", (int)c));
            }
            
            Console.WriteLine(sb.ToString());
        }
    }
}
