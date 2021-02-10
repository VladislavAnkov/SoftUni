using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        public static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());

			List<Car> cars = new List<Car>();

			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

				string model = input[0];

				int engineSpeed = int.Parse(input[1]);
				int enginePower = int.Parse(input[2]);

				Engine engine = new Engine(engineSpeed, enginePower);

				int cargoWeight = int.Parse(input[3]);
				string cargoType = input[4];
				Cargo cargo = new Cargo(cargoWeight, cargoType);

				int count = 5;

				Tire tireOne = CreateTire(count, input);
				Tire tireTwo = CreateTire(count+=2, input);
				Tire tireThree = CreateTire(count+=2, input);
				Tire tireFour = CreateTire(count+=2, input);

				Tire[] tires = new Tire[] { tireOne, tireTwo, tireThree, tireFour };

				Car car = new Car(model, engine, cargo, tires);

				cars.Add(car);
			}

			string typeOfCargo = Console.ReadLine();

			List<Car> filtered = new List<Car>();

			if (typeOfCargo == "fragile")
			{
				filtered = cars.Where(c => c.Cargo.Type == "fragile")
								.Where(c => c.Tires.Any(y => y.Pressure < 1)).ToList();

				foreach (Car car in filtered)
				{
					Console.WriteLine(car);
				}
			}
			else
			{
				filtered = cars.Where(c => c.Cargo.Type == "flamable")
								.Where(c => c.Engine.Power > 250)
								.ToList();

				foreach (Car car in filtered)
				{
					Console.WriteLine(car);
				}
			}
		}

		public static Tire CreateTire(int count, string[] input)
		{
			double tirePressure = double.Parse(input[count++]);
			int tireAge = int.Parse(input[count++]);

			Tire tire = new Tire(tirePressure, tireAge);

			return tire;
		}
	}
}
