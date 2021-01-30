using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
		public static void Main()
		{
			List<int> numbers = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			numbers.Reverse();

			int divider = int.Parse(Console.ReadLine());

			Func<int, int, bool> isNotDivisible = (num, div) => num % div != 0;

			List<int> notDivisible = new List<int>();

			foreach (int num in numbers)
			{
				if (isNotDivisible(num, divider))
				{
					notDivisible.Add(num);
				}
			}

			Console.WriteLine(string.Join(" ", notDivisible));
		}
	}
}
