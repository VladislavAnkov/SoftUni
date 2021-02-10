using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
		public static void Main()
		{
			int[] range = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int firstNumber = range[0];
			int lastNumber = range[1];

			List<int> numbers = new List<int>();

			for (int i = firstNumber; i <= lastNumber; i++)
			{
				numbers.Add(i);
			}

			string command = Console.ReadLine();

			Predicate<int> oddOrEvenNum = SetPredicate(command);

			foreach (int number in numbers)
			{
				if (oddOrEvenNum(number))
				{
					Console.Write(number + " ");
				}
			}
		}

		public static Predicate<int> SetPredicate(string condition)
		{
			if (condition == "odd")
			{
				return n => n % 2 != 0;
			}

			return n => n % 2 == 0;
		}
	}
}
