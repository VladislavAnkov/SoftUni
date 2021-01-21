﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());

			Dictionary<int, int> numbers = new Dictionary<int, int>();

			for (int i = 0; i < n; i++)
			{
				int currentNum = int.Parse(Console.ReadLine());

				if (!numbers.ContainsKey(currentNum))
				{
					numbers.Add(currentNum, 0);
				}

				numbers[currentNum]++;
			}

			foreach (var item in numbers.Where(x => x.Value % 2 == 0))
			{
				Console.WriteLine(item.Key);
			}
		}
    }
}
