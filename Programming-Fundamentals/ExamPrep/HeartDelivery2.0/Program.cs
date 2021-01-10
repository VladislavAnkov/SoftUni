using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HeartDelivery2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();

            int jumpedPosition = 0;
            string command = Console.ReadLine();

            while (command  != "Love!")
            {
                string[] cmdArgs = command.Split();
                int jumpLength = int.Parse(cmdArgs[1]);
                jumpedPosition += jumpLength;

                if (jumpedPosition >= 0 && jumpedPosition < neighborhood.Length)
                {
                    neighborhood[jumpedPosition] -= 2;
                }
                else
                {
                    jumpedPosition = 0;
                    neighborhood[jumpedPosition] -= 2;
                }

                if (neighborhood[jumpedPosition] == 0)
                {
                    Console.WriteLine($"Place {jumpedPosition} has Valentine's day.");
                }
                else
                {
                    Console.WriteLine($"Place {jumpedPosition} already had Valentine's day.");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {jumpedPosition}.");

            int successCount = neighborhood.Count(x => x == 0);
            int failCount = neighborhood.Count(x => x != 0);

            if (failCount > 0)
            {
                Console.WriteLine($"Cupid has failed {failCount} places.");

            }
            else
            {
                Console.WriteLine("Mission was successful!");
            }
        }
    }
}
