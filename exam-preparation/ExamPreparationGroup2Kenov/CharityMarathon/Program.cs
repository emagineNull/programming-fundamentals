using System;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var marathonLengthDays = int.Parse(Console.ReadLine());
            var runnersCount = int.Parse(Console.ReadLine());
            var avgNumOfLapsPerRunner = int.Parse(Console.ReadLine());
            var trackLength = int.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var donationPerKilometer = double.Parse(Console.ReadLine());

            var moneyRaised = 0.0;
            var totalKilometers = 0.0;

            if (marathonLengthDays == 0 || runnersCount == 0 || avgNumOfLapsPerRunner == 0 || trackLength == 0 || trackCapacity == 0)
            {
                Console.WriteLine($"Money raised: {moneyRaised:f2}");
                return;
            }

            if (trackCapacity >= runnersCount)
            {
                for (int i = 0; i < marathonLengthDays; i++)
                {
                    totalKilometers += runnersCount * avgNumOfLapsPerRunner * trackLength;
                }
            }

            if (trackCapacity < runnersCount)
            {
                for (int i = 0; i < marathonLengthDays; i++)
                {
                    if (runnersCount >= trackCapacity)
                    {
                        totalKilometers += trackCapacity * avgNumOfLapsPerRunner * trackLength;
                    }
                    else
                    {
                        totalKilometers += runnersCount * avgNumOfLapsPerRunner * trackLength;
                    }
                    runnersCount -= trackCapacity;
                    if (runnersCount <= 0)
                    {
                        break;
                    }
                }
            }

            moneyRaised = totalKilometers / 1000.0 * donationPerKilometer;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
