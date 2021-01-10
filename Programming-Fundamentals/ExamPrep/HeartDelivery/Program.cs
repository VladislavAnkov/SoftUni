using System;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            int currentIndex = 0;
            int lastPosition = 0;

            while ((command  != "Love!"))
            {
                string[] cmdArgs = command.Split().ToArray();
                int index = int.Parse(cmdArgs[1]);
                currentIndex += index;

                if (currentIndex <= neighborhood.Length - 1)
                {
                    if (neighborhood[currentIndex] > 2)
                    {
                        neighborhood[currentIndex] -= 2;
                    }
                    else if (neighborhood[currentIndex] == 2)
                    {
                        neighborhood[currentIndex] -= 2;
                        Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                    }
                    else if (neighborhood[currentIndex] == 0)
                    {
                        Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                    }
                }
                else if (currentIndex > neighborhood.Length - 1)
                {
                    currentIndex = 0;

                    if (neighborhood[currentIndex] > 2)
                    {
                        neighborhood[currentIndex] -= 2;
                    }
                    else if (neighborhood[currentIndex] == 2)
                    {
                        neighborhood[currentIndex] -= 2;
                        Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                    }
                    else if (neighborhood[currentIndex] == 0)
                    {
                        Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                    }
                }

                command = Console.ReadLine();

                if (command == "Love!")
                {
                    lastPosition = currentIndex;
                    Console.WriteLine($"Cupid's last position was {lastPosition}.");
                }
            }

            int failedCount = 0;

            for (int i = 0; i < neighborhood.Length; i++)
            {
                if (neighborhood[i] != 0)
                {
                    failedCount++;
                }
            }

            if (failedCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failedCount} places.");
            }
        }
    }
}
