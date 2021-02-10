using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class Program
    {
        public static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());
			List<Engine> engines = new List<Engine>();
			List<Car> cars = new List<Car>();

			for (int i = 0; i < n; i++)
			{
				string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
				string model = engineInfo[0];
				int power = int.Parse(engineInfo[1]);

				if (engineInfo.Length < 4)
				{
                    if (engineInfo.Length == 3)
                    {
						int num;
						bool isNumeric = int.TryParse(engineInfo[2], out num);
						if (isNumeric)
						{
							int displacement = num;
							Engine engine = new Engine(model, power, displacement);

							engines.Add(engine);
						}
						else
						{
							string efficiency = engineInfo[2];
							Engine engine = new Engine(model, power, efficiency);

							engines.Add(engine);
						}
					}
                    else
                    {
						Engine engine = new Engine(model, power);
						engines.Add(engine);
                    }
					
				}
				else
				{
					int displacement = int.Parse(engineInfo[2]);
					string efficiency = engineInfo[3];

					Engine engine = new Engine(model, power, displacement, efficiency);
					engines.Add(engine);
				}
			}

			int m = int.Parse(Console.ReadLine());

			for (int j = 0; j < m; j++)
			{
				string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
				string model = carInfo[0];
				string engineModel = carInfo[1];

				Engine engine = engines.Find(e => e.Model == engineModel);

				if (carInfo.Length < 4)
				{
					if (carInfo.Length == 3)
					{
						int num;
						bool isNumeric = int.TryParse(carInfo[2], out num);
						if (isNumeric)
						{
							int weight = num;
							Car car = new Car(model, engine, weight);
							cars.Add(car);
						}
						else
						{
							string color = carInfo[2];
							Car car = new Car(model, engine, color);
							cars.Add(car);
						}
					}
					else
					{
						Car car = new Car(model, engine);
						cars.Add(car);
					}
				}
				else
				{
					int weight = int.Parse(carInfo[2]);
					string color = carInfo[3];
					Car car = new Car(model, engine, weight, color);
					cars.Add(car);
				}
			}

			foreach (Car car in cars)
			{
				Console.WriteLine($"{car.Model}:");
				Console.WriteLine($"  {car.Engine.Model}:");
				Console.WriteLine($"    Power: {car.Engine.Power}");

				if (car.Engine.Displacement == 0)
				{
					Console.WriteLine($"    Displacement: n/a");
				}
				else
				{
					Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
				}

				if (car.Engine.Efficiency == null)
				{
					Console.WriteLine($"    Efficiency: n/a");
				}
				else
				{
					Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
				}

				if (car.Weight == 0)
				{
					Console.WriteLine($"  Weight: n/a");
				}
				else
				{
					Console.WriteLine($"  Weight: {car.Weight}");
				}

				if (car.Color == null)
				{
					Console.WriteLine($"  Color: n/a");
				}
				else
				{
					Console.WriteLine($"  Color: {car.Color}");
				}
			}
		}
    }
}
