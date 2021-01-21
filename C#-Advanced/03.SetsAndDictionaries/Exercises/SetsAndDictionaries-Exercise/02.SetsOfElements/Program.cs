using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] input = Console.ReadLine()
			.Split(" ", StringSplitOptions.RemoveEmptyEntries)
			.Select(int.Parse)
			.ToArray();

			int n = input[0];
			int m = input[1];

			HashSet<int> firstSet = new HashSet<int>();
			HashSet<int> secondSet = new HashSet<int>();

			for (int i = 0; i < n + m; i++)
			{
				int currentNum = int.Parse(Console.ReadLine());
				if (i < n)
				{
					firstSet.Add(currentNum);
				}
				else
				{
					secondSet.Add(currentNum);
				}
			}

			firstSet.IntersectWith(secondSet);

			foreach (int number in firstSet)
			{
				Console.Write(number + " ");
			}
		}
    }
}
