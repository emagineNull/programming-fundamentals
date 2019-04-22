using System;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string decrypted = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                decrypted += (char)(letter + key);
            }

            Console.WriteLine(decrypted);
        }
    }
}
