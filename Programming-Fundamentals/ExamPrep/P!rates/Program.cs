using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

		string[] command = Console.ReadLine().Split("||");

		while (command[0] != "Sail")
		{
			string city = command[0];
			int population = int.Parse(command[1]);
			int gold = int.Parse(command[2]);

			if (cities.ContainsKey(city) == false)
			{
				cities.Add(city, new List<int> { population, gold });
			}
			else
			{
				cities[city][0] += population;
				cities[city][1] += gold;
			}

			command = Console.ReadLine().Split("||");
		}

		string[] events = Console.ReadLine().Split("=>");

		while (events[0] != "End")
		{
			string cmd = events[0];
			string town = events[1];

			if (cmd == "Plunder")
			{
				int people = int.Parse(events[2]);
				int money = int.Parse(events[3]);
				cities[town][0] -= people;
				cities[town][1] -= money;
				Console.WriteLine($"{town} plundered! {money} gold stolen, {people} citizens killed.");

				if (cities[town][0] <= 0 || cities[town][1] <= 0)
				{
					Console.WriteLine($"{town} has been wiped off the map!");
					cities.Remove(town);
				}
				
			}
			else if (cmd == "Prosper")
			{
				int money = int.Parse(events[2]);

				if (money < 0)
				{
					Console.WriteLine("Gold added cannot be a negative number!");
				}
				else
				{
					cities[town][1] += money;
					Console.WriteLine($"{money} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
				}
			}
			events = Console.ReadLine().Split("=>");
		}

		if (cities.Count > 0)
		{
			Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

			foreach (var city in cities.OrderByDescending(x => x.Value[1]).ThenBy(n => n.Key))
			{

				int people = city.Value[0];
				int money = city.Value[1];
				Console.WriteLine($"{city.Key} -> Population: {people} citizens, Gold: {money} kg");
			}
		}
	}
}