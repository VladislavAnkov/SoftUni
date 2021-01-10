using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            numbers.Reverse();

            List<string> reversedNumbers = new List<string>();

            foreach (string currentNum in numbers)
            {
                string[] numArray = currentNum.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (string element in numArray)
                {
                    reversedNumbers.Add(element);
                }
            }

            Console.WriteLine(string.Join(' ', reversedNumbers));
        }
    }
}
