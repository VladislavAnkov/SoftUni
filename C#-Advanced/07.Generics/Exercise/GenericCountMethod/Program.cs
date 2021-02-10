using System;
using System.Collections.Generic;

namespace GenericCountMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());

			Box<double> box = new Box<double>();
			List<double> list = new List<double>();

			for (int i = 0; i < n; i++)
			{
				double input = double.Parse(Console.ReadLine());

				list.Add(input);
			}

			double element = double.Parse(Console.ReadLine());

			Console.WriteLine(box.CountGreaterElements(list, element));
		}
    }
}
