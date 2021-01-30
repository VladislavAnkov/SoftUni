using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CustomMinFunc
{
    class Program
    {
		public static void Main()
		{
			Func<List<int>, int> getMinValue = nums =>
			{
				int minNumber = int.MaxValue;
				foreach (int num in nums)
				{
					if (num < minNumber)
					{
						minNumber = num;
					}
				}
				return minNumber;
			};

			List<int> numbers = Console.ReadLine()
							.Split(" ", StringSplitOptions.RemoveEmptyEntries)
							.Select(int.Parse)
							.ToList();

			int minNum = getMinValue(numbers);

			Console.WriteLine(minNum);

		}
	}
}
