﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
		public Tire(double pressure, int age)
		{
			this.Pressure = pressure;
			this.Age = age;
		}

		public int Age { get; set; }

		public double Pressure { get; set; }
	}
}
