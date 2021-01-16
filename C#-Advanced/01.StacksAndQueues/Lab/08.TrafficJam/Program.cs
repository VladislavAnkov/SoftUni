using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
			int numberOfCars = int.Parse(Console.ReadLine());

			Queue<string> cars = new Queue<string>();

			string command = Console.ReadLine();

			int carsPassed = 0;

			while (command != "end")
			{
				if (command == "green")
				{
					for (int i = 0; i < numberOfCars; i++)
					{
						if (cars.Count > 0)
						{
							Console.WriteLine($"{cars.Dequeue()} passed!");
							carsPassed++;
						}
						else
						{
							break;
						}
					}
				}
				else
				{
					cars.Enqueue(command);
				}

				command = Console.ReadLine();
			}

			Console.WriteLine($"{carsPassed} cars passed the crossroads.");
		}
    }
}
