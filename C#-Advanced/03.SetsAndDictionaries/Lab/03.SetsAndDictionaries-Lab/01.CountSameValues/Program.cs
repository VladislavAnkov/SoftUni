using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValues
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> numbers = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                double currentNumber = input[i];

                if (!numbers.ContainsKey(currentNumber))
                {
                    numbers.Add(currentNumber, 0);
                }

                numbers[currentNumber]++;
            }

            foreach (var kvp in numbers)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
