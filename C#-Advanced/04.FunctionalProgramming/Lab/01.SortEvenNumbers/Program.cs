using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
			char[] delimiters = new char[] { ' ', ',' };

			List<int> numbers = Console.ReadLine()
				.Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
				.Select(x => Convert.ToInt32(x))
				.Where(x => x % 2 == 0)
				.OrderBy(x => x)
				.ToList();


			Console.WriteLine(string.Join(", ", numbers));
		}
    }
}
