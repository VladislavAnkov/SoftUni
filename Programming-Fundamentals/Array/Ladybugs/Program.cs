using System;
using System.Linq;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] initialIndex = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] field = new int[fieldSize];

            for (int i = 0; i < initialIndex.Length; i++)
            {
                int currentIndex = initialIndex[i];

                if (currentIndex >= 0 && currentIndex < field.Length)
                {
                    field[currentIndex] = 1;
                }

            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                int ladybugIndex = int.Parse(command[0]);
                string direction = command[1];
                int flightLength = int.Parse(command[2]);

                if (ladybugIndex < 0 || ladybugIndex > field.Length - 1 || field[ladybugIndex] == 0)
                {
                    continue;
                }

                field[ladybugIndex] = 0;

                if (direction == "right")
                {
                    int landIndex = ladybugIndex + flightLength;

                    if (landIndex > field.Length - 1)
                    {
                        break;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flightLength;
                            if (landIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex < field.Length - 1)
                    {
                        field[landIndex] = 1;

                    }
                }
                else if (direction == "left")
                {
                    int landIndex = ladybugIndex - flightLength;

                    if (landIndex < 0)
                    {
                        break;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flightLength;
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex >= 0 && landIndex < field.Length - 1)
                    {
                        field[landIndex] = 1;

                    }

                }
            }

            Console.WriteLine(string.Join(' ', field));
        }
    }
}
