using System;

namespace BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }

        static void PrintFooter()
        {
            Console.WriteLine("------------------------------\n© SoftUni");
        }

    }
}
