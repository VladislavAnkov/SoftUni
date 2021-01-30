using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
			int length = int.Parse(Console.ReadLine());

			List<string> names = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			Func<string, bool> isNameShort = n => n.Length <= length;
			Action<List<string>> printNames = listNames =>
			{
				foreach (string name in listNames)
				{
					Console.WriteLine(name);
				}
			};

			printNames(names.Where(isNameShort).ToList());
		}
    }
}
