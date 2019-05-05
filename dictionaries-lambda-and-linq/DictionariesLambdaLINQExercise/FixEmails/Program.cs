using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();

            int counter = 1;
            string emailAdress = string.Empty;
            string name = Console.ReadLine();
            while (name != "stop")
            {
                emailAdress = Console.ReadLine();
                emails.Add(name, emailAdress);
                name = Console.ReadLine();
            }

            foreach (var email in emails)
            {
                char[] emailDomain = email.Value.ToCharArray();
                string domainEnd = string.Empty;
                for (int i = emailDomain.Length - 2; i < emailDomain.Length; i++)
                {
                    domainEnd = domainEnd + emailDomain[i]; 
                }
                domainEnd = domainEnd.ToLower();
                if (domainEnd != "us" && domainEnd != "uk")
                {
                    Console.WriteLine($"{email.Key} -> {email.Value}");
                }
            }
        }
    }
}
