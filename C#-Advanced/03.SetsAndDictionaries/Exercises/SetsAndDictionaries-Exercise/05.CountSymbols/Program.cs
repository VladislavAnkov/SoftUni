using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
			string text = Console.ReadLine();

			Dictionary<char, int> characters = new Dictionary<char, int>();

			for (int i = 0; i < text.Length; i++)
			{
				char currentChar = text[i];
				if (!characters.ContainsKey(currentChar))
				{
					characters.Add(currentChar, 0);
				}

				characters[currentChar]++;
			}

			foreach (var item in characters.OrderBy(x => x.Key))
			{
				Console.WriteLine($"{item.Key}: {item.Value} time/s");
			}
		}
    }
}
