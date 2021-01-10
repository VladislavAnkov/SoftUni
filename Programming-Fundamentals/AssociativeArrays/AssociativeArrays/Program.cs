using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

            foreach (double number in input)
            {
                if (numbers.ContainsKey(number))
                {
                    numbers[number]++;
                }
                else
                {
                    numbers.Add(number, 1);
                }
            }

            foreach (KeyValuePair<double, int> kvp in numbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
