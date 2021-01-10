using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();

		for (int i = 0; i < n; i++)
		{
			string[] input = Console.ReadLine().Split("|");

			string car = input[0];
			int mileage = int.Parse(input[1]);
			int fuel = int.Parse(input[2]);

			if (!cars.ContainsKey(car))
			{
				cars.Add(car, new List<int> { mileage, fuel });
			}
		}

		string[] cmdArgs = Console.ReadLine().Split(" : ");

		while (cmdArgs[0] != "Stop")
		{
			string command = cmdArgs[0];
			string car = cmdArgs[1];

			if (command == "Drive")
			{
				int distance = int.Parse(cmdArgs[2]);
				int fuelNeeded = int.Parse(cmdArgs[3]);

				if (cars[car][1] >= fuelNeeded)
				{
					cars[car][0] += distance;
					cars[car][1] -= fuelNeeded;

					Console.WriteLine($"{car} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");

                    if (cars[car][0] >= 100000)
                    {
						cars.Remove(car);
						Console.WriteLine($"Time to sell the {car}!");
                    }
				}
				else
				{
					Console.WriteLine("Not enough fuel to make that ride");
				}
			}
			else if (command == "Refuel")
			{
				int fuel = int.Parse(cmdArgs[2]);
				int currentValue = cars[car][1];
				cars[car][1] += fuel;
                if (cars[car][1] > 75)
                {
					fuel = 75 - currentValue;
					cars[car][1] = 75;
                }

                Console.WriteLine($"{car} refueled with {fuel} liters");
			}
			else if (command == "Revert")
			{
				int kilometers = int.Parse(cmdArgs[2]);

				cars[car][0] -= kilometers;

                if (cars[car][0] < 10000)
                {
					cars[car][0] = 10000;
					continue;
                }

                Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
			}

			cmdArgs = Console.ReadLine().Split(" : ");
		}

		foreach (var car in cars.OrderByDescending(mileage => mileage.Value[0]).ThenBy(name => name.Value[1]))
        {
            Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
        }
	}
}