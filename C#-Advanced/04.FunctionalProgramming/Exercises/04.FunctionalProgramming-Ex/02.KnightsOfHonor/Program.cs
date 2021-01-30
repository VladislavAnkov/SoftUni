using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
		public static void Main()
		{
			List<string> names = Console.ReadLine()
								.Split(" ", StringSplitOptions.RemoveEmptyEntries)
								.ToList();

			foreach (string name in names)
			{
				Action<string> printer = Printer(name);
				printer(name);
			}

		}

		public static Action<string> Printer(string name)
		{
			return n => Console.WriteLine($"Sir {n}");
		}
	}
}
