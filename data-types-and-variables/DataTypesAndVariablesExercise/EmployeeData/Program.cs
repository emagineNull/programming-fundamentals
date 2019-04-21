using System;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong personalIdNumber = ulong.Parse(Console.ReadLine());
            uint uniqueEmployeeNumber = uint.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\nLast name: {lastName}\nAge: {age}\nGender: {gender}\n" +
                $"Personal ID: {personalIdNumber}\nUnique Employee number: {uniqueEmployeeNumber}");
        }
    }
}
