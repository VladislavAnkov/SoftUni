using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>(new int[] { 5, 6, 8, 3});
            // numbers.Add(5);

            //string input = Console.ReadLine();

            //List<string> values = input.Split(' ').ToList();
            //List<int> numbers = new List<int>();

            //for (int i = 0; i < values.Count; i++)
            //{
            //    numbers.Add(int.Parse(values[i]));
            //}

            List<int> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
        }
    }
}
