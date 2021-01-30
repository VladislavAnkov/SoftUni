using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ApliedArithmetics
{
    class Program
    {
		public static void Main()
		{
			List<int> numbers = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			string command = Console.ReadLine();

			while (command != "end")
			{
				if (command == "print")
				{
					Action<List<int>> printer = nums =>
						Console.WriteLine(string.Join(" ", nums));

					printer(numbers);
				}
				else
				{
					Func<int, int> getValues = ArithmeticalOperations(command);

					for (int i = 0; i < numbers.Count; i++)
					{
						numbers[i] = getValues(numbers[i]);
					}
				}

				command = Console.ReadLine();
			}
		}

		public static Func<int, int> ArithmeticalOperations(string condition)
		{
			if (condition == "add")
			{
				return n => n + 1;
			}
			else if (condition == "multiply")
			{
				return n => n * 2;
			}
			else if (condition == "subtract")
			{
				return n => n - 1;
			}

			return n => n;
		}
	}
}
