using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FunctionalProgramming_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());

            List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> numbers = Enumerable.Range(1, endOfRange).ToList();

            for (int i = 0; i < endOfRange; i ++)
            {
                if (dividers.All(div => numbers[i] % div == 0))
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
