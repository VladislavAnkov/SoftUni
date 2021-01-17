using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RackCapacity
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] clothesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int rackCapacity = int.Parse(Console.ReadLine());

			Stack<int> clothes = new Stack<int>(clothesInput);

			int racksCount = 1;
			int sum = 0;

			while (clothes.Any())
			{
				int currentItem = clothes.Peek();

				if (sum + currentItem <= rackCapacity)
				{
					sum += currentItem;
					clothes.Pop();
				}
				else
				{
					sum = 0;
					racksCount++;

				}
			}

			Console.WriteLine(racksCount);
		}
    }
}
