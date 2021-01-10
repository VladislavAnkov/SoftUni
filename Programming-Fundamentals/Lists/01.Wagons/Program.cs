using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Wagons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine()
                             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .ToArray();

            while(input[0] != "end")
            {
                if (input.Length > 1)
                {
                    wagons.Add(int.Parse(input[1]));
                }
                else
                {
                    int number = int.Parse(input[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + number <= maxCapacity)
                        {
                            wagons[i] += number;
                            break;
                        }
                    }
                }

                input = Console.ReadLine()
                             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .ToArray();
            }

            foreach (var wagon in wagons)
            {
                Console.Write(wagon + " ");
            }
        }
    }
}
