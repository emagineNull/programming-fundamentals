using System;

namespace DebuggingExerciseSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            char search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == search)
                {
                    hasMatch = true;
                    
                    int endIndex = jump + 1;

                    if (endIndex > text.Length - i)
                    {
                        endIndex = text.Length - i;
                    }

                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);

                    i += jump;
                }
            }

            if (hasMatch == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
