using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
			int foodQuantity = int.Parse(Console.ReadLine());

			int[] ordersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

			Queue<int> orders = new Queue<int>(ordersInput);

			Console.WriteLine(orders.Max());
			bool isSuccessfull = true;

			while (orders.Any())
			{
				int currentOrder = orders.Peek();

				if (currentOrder <= foodQuantity)
				{
					foodQuantity -= currentOrder;
					orders.Dequeue();
				}
				else
				{
					isSuccessfull = false;
					break;
				}
			}

			if (isSuccessfull)
			{
				Console.WriteLine("Orders complete");
			}
			else
			{
				Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
			}
		}
    }
}
