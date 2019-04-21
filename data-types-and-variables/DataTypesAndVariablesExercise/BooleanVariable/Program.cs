using System;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string booleanVar = Console.ReadLine();
            if (Convert.ToBoolean(booleanVar) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
