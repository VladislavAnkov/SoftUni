using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfClothes = int.Parse(Console.ReadLine());

			Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();


			for (int i = 0; i < numberOfClothes; i++)
			{
				string[] tokens = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
				string color = tokens[0];
				string clothes = tokens[1];
				string[] splittedClothes = clothes.Split(",");

				if (!wardrobe.ContainsKey(color))
				{
					wardrobe.Add(color, new Dictionary<string, int>());
				}

				for (int j = 0; j < splittedClothes.Length; j++)
				{
					string currentItem = splittedClothes[j];

					if (wardrobe[color].ContainsKey(currentItem))
					{
						wardrobe[color][currentItem]++;
					}
					else
					{
						wardrobe[color].Add(currentItem, 1);
					}
				}

			}

			string[] clothesToLookFor = Console.ReadLine().Split();
			string desiredColor = clothesToLookFor[0];
			string desiredClothes = clothesToLookFor[1];

			foreach (var kvp in wardrobe)
			{
				Console.WriteLine($"{kvp.Key} clothes:");

				foreach (var clothing in kvp.Value)
				{
					if (clothing.Key == desiredClothes && kvp.Key == desiredColor)
					{
						Console.WriteLine($"* {desiredClothes} - {clothing.Value} (found!)");
						continue;
					}

					Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
				}
			}

		}

	}
}