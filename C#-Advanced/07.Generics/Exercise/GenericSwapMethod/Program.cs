using System;
using System.Linq;

namespace GenericSwapMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());

			Box<int> box = new Box<int>();

			for (int i = 0; i < n; i++)
			{
				int input = int.Parse(Console.ReadLine());

				box.Add(input);
			}

			int[] indecies = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int firstIndex = indecies[0];
			int secondIndex = indecies[1];

			box.SwapElements(firstIndex, secondIndex);

			Console.WriteLine(box);
		}
    }
}
