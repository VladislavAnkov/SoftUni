using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Car
    {
		public Car(string model, double fuelAmount, double fuelPerKM)
		{
			this.Model = model;
			this.FuelAmount = fuelAmount;
			this.FuelConsumptionPerKilometer = fuelPerKM;
			this.TravelledDistance = 0;
		}

		public string Model { get; set; }
		public double FuelAmount { get; set; }
		public double FuelConsumptionPerKilometer { get; set; }
		public double TravelledDistance { get; set; }

		public bool Drive(double distance)
		{
			double fuelNeeded = this.FuelConsumptionPerKilometer * distance;
			if (fuelNeeded <= this.FuelAmount)
			{
				this.TravelledDistance += distance;
				this.FuelAmount -= fuelNeeded;
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
