using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] cmdArgs = Console.ReadLine().Split();

			int n = int.Parse(cmdArgs[0]); // N - number of elements to add to the Queue
			int s = int.Parse(cmdArgs[1]); // S - number of elements to remove from the Queue
			int x = int.Parse(cmdArgs[2]); // X - element to look for in the Queue;

			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			Queue<int> integers = new Queue<int>(numbers);

			for (int i = 0; i < s; i++)
			{
				integers.Dequeue();
			}

			if (integers.Contains(x))
			{
				Console.WriteLine("true");
			}
			else
			{
				if (integers.Any())
				{
					Console.WriteLine(integers.Min());
				}
				else
				{
					Console.WriteLine(0);
				}
			}
		}
    }
}
