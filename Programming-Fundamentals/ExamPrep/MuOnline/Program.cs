using System;

public class Program
{
	public static void Main()
	{
		int health = 100;
		int bitCoins = 0;
		int room = 0;
		bool hasManaged = true;

		string[] dungeonRoom = Console.ReadLine().Split("|");

		for (int i = 0; i < dungeonRoom.Length; i++)
		{
			string[] cmdArgs = dungeonRoom[i].Split();
			string command = cmdArgs[0];
			int number = int.Parse(cmdArgs[1]);
			room++;

			if (command == "potion")
			{
				if (health + number <= 100) // = ? 
				{
					health += number;

					Console.WriteLine($"You healed for {number} hp.");
					Console.WriteLine($"Current health: {health} hp.");
				}
				else
				{
					number = 100 - health;
					health = 100;
					Console.WriteLine($"You healed for {number} hp.");
					Console.WriteLine($"Current health: {health} hp.");
				}
			}
			else if (command == "chest")
			{
				bitCoins += number;
				Console.WriteLine($"You found {number} bitcoins.");
			}
			else
			{
				health -= number;

				if (health > 0)
				{
					Console.WriteLine($"You slayed {command}.");
				}
				else
				{
					Console.WriteLine($"You died! Killed by {command}.");
					Console.WriteLine($"Best room: {room}");
					hasManaged = false;
					break;
				}
			}
		}

		if (hasManaged)
		{
			string result = $"You've made it!\nBitcoins: {bitCoins}\nHealth: {health}".Replace("\n", Environment.NewLine);
			Console.WriteLine(result);
		}
	}
}