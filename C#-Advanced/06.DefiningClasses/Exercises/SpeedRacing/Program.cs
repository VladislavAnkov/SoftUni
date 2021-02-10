using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class Program
    {
        public static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());

			List<Car> cars = new List<Car>();

			for (int i = 0; i < n; i++)
			{
				string[] carData = Console.ReadLine().Split();
				string model = carData[0];
				double fuelAmount = double.Parse(carData[1]);
				double fuelConsumption = double.Parse(carData[2]);

				Car car = new Car(model, fuelAmount, fuelConsumption);
				cars.Add(car);
			}

			string command = Console.ReadLine();

			while (command != "End")
			{
				string[] splitted = command.Split(" ");
				string model = splitted[1];
				double distance = double.Parse(splitted[2]);

				Car car = cars.First(c => c.Model == model);

				bool isPossible = car.Drive(distance);

				if (isPossible == false)
				{
					Console.WriteLine("Insufficient fuel for the drive");
				}

				command = Console.ReadLine();
			}

			foreach (Car car in cars)
			{
				Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
			}
		}
    }
}
