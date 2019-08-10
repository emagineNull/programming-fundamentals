using System;
using System.Collections.Generic;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var securityKey = int.Parse(Console.ReadLine());

            var input = new string[3];
            var websites = new List<string>();
            var totalLoss = 0.0M;
            var length = n;

            for (int i = 0; i < length; i++)
            {
                input = Console.ReadLine().Split(' ');

                totalLoss += decimal.Parse(input[1]) * decimal.Parse(input[2]);

                websites.Add(input[0]);
            }
            
            var securityToken = Math.Pow(securityKey, n);

            foreach (var sites in websites)
            {
                Console.WriteLine(sites);
            }

            Console.WriteLine($"Total Loss: {totalLoss:f20}");

            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
