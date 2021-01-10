using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());

		Dictionary<string, List<double>> plants = new Dictionary<string, List<double>>();
		char[] separators = new char[] { '<', '-', '>' };

		for (int i = 0; i < n; i++)
		{
			string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

			string plant = input[0];
			double rarity = double.Parse(input[1]);

			if (!plants.ContainsKey(plant))
			{
				plants.Add(plant, new List<double> { rarity });
			}
			else
			{
				plants[plant].Clear();
				plants[plant].Add(rarity);
			}
		}
		char[] separators2 = new char[] { ',', ' ', ':', '-' };
		string[] cmdArgs = Console.ReadLine().Split(separators2, StringSplitOptions.RemoveEmptyEntries);

		while (cmdArgs[0] != "Exhibition")
		{
			string command = cmdArgs[0];
			string plant = cmdArgs[1];

			if (command.ToLower() == "rate")
			{
				double rating = double.Parse(cmdArgs[2]);
				plants[plant].Add(rating);
			}
			else if (command.ToLower() == "update")
			{
				double newRarity = double.Parse(cmdArgs[2]);
				plants[plant][0] = newRarity;
			}
			else if (command.ToLower() == "reset")
			{
				plants[plant].RemoveRange(1, plants[plant].Count - 1);
			}
			else
			{
				Console.WriteLine("error");
			}

			cmdArgs = Console.ReadLine().Split(separators2, StringSplitOptions.RemoveEmptyEntries);
		}

		Console.WriteLine("Plants for the exhibition:");

		
		foreach (var plant in plants)
		{
			double averageRating = 0.0;

			int count = 0;

			for (int k = 1; k <= plants[plant.Key].Count -1; k++)
			{
				if(plants[plant.Key].Count == 1)
                {
					continue;
                }
				double currentRating = plants[plant.Key][k];
				averageRating += currentRating;
				count++;
			}

            if (count == 0)
            {
				averageRating = 0.0;
            }
            else
            {
				averageRating /= count;
			}
			

			plants[plant.Key].Add(averageRating);
			
		}

        foreach (var item in plants.OrderByDescending(p => p.Value[0]).ThenBy(avgRating => avgRating.Value[avgRating.Value.Count-1]))
        {
			string currentPlant = item.Key.ToString();
			double currentRarity = plants[item.Key][0];

			Console.WriteLine($"- {currentPlant}; Rarity: {currentRarity}; Rating: {item.Value[item.Value.Count-1]:f2}");
		}
	}
}