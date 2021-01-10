using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Vehicles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();

            List<Vehicle> vehicles = new List<Vehicle>();
            double sumHorsepowerCars = 0;
            double sumHorsepowerTrucks = 0;
            double carCount = 0;
            double truckCount = 0;

            while (input[0] != "End")
            {
                string type = input[0];
                string model = input[1];
                string color = input[2];
                double horsepower = double.Parse(input[3]);

                if (type == "car")
                {
                    sumHorsepowerCars += horsepower;
                    carCount++;
                }
                else if (type == "truck")
                {
                    sumHorsepowerTrucks += horsepower;
                    truckCount++;
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

                modelsOfVehicles = Console.ReadLine();
            }
            if (carCount > 0)
            {
                double carsAvgHP = sumHorsepowerCars / carCount * 1.0;
                Console.WriteLine($"Cars have average horsepower of: {carsAvgHP:f2}.");

            }

            if (truckCount > 0)
            {
                double trucksAvgHP = sumHorsepowerTrucks / truckCount * 1.0;
                Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHP:f2}.");

            }

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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {Horsepower}");

            return sb.ToString().TrimEnd();
        }
    }
}
