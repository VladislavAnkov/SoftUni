using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatlogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();

            List<Vehicle> vehicles = new List<Vehicle>();
            double sumHorsepowerCars = 0;
            double sumHorsepowerTrucks = 0;

            while (input[0] != "End")
            {
                string type = input[0];
                string model = input[1];
                string color = input[2];
                double horsepower = double.Parse(input[3]);

                if (type == "car")
                {
                    sumHorsepowerCars += horsepower;
                }
                else if (type == "truck")
                {
                    sumHorsepowerTrucks += horsepower;
                }

                Vehicle vehicle = new Vehicle(type, model, color, horsepower);

                vehicles.Add(vehicle);

                input = Console.ReadLine().Split(" ").ToArray();


            }

            string modelsOfVehicles = Console.ReadLine();


            while (modelsOfVehicles != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    if (vehicle.Model == modelsOfVehicles)
                    {
                        string vehicleType = string.Empty;
                        StringBuilder sb = new StringBuilder();
                        if (vehicle.Type == "car")
                        {
                            vehicleType = "Car";
                        }
                        else
                        {
                            vehicleType = "Truck";
                        }

                        sb.AppendLine($"Type: {vehicleType}");
                        sb.AppendLine($"Model: {vehicle.Model}");
                        sb.AppendLine($"Color: {vehicle.Color}");
                        sb.AppendLine($"Horsepower: {vehicle.Horsepower}");

                        Console.WriteLine(sb.ToString());

                    }
                }
                // vehicles.Find(x => x.Model.Contains(modelsOfVehicles));
                modelsOfVehicles = Console.ReadLine();
            }

            double carsAvgHP = sumHorsepowerCars / vehicles.Count(a => a.Type == "car");
            double trucksAvgHP = sumHorsepowerTrucks / vehicles.Count(a => a.Type == "truck");

            Console.WriteLine($"Cars have average horsepower of: {carsAvgHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHP:f2}.");
        }
    }

    class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public double Horsepower { get; set; }

        public Vehicle(string type, string model, string color, double horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
    }
}
