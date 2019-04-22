using System;

namespace BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string speed = string.Empty;
            int tilesBoatOne = 0;
            int tilesBoatTwo = 0;

            for (int i = 1; i <= n; i++)
            {
                speed = Console.ReadLine();
                if (tilesBoatOne < 50 && tilesBoatTwo < 50)
                {
                    if (speed == "UPGRADE")
                    {
                        firstBoat += (char)3;
                        secondBoat += (char)3;
                        continue;
                    }
                    if (i % 2 != 0)
                    {
                        tilesBoatOne += speed.Length;
                    }
                    else
                    {
                        tilesBoatTwo += speed.Length;
                    }
                }
            }

            if (tilesBoatOne > tilesBoatTwo)
            {
                Console.WriteLine(firstBoat);
            }
            else
            {
                Console.WriteLine(secondBoat);
            }
        }
    }
}
