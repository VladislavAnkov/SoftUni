using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();

            int[] bombNumber = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

            int bomb = bombNumber[0];
            int power = bombNumber[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];

                if (currentNum == bomb)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }

                    int endIndexToRemove = endIndex - startIndex + 1;
                    numbers.RemoveRange(startIndex, endIndexToRemove);
                }
            }
            Console.WriteLine(numbers.Sum());

        }
    }
}
