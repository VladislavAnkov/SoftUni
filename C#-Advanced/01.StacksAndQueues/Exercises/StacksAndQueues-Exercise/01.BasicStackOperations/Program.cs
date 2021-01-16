using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] cmdArgs = Console.ReadLine().Split();

			int n = int.Parse(cmdArgs[0]); // n - represents the number of elements to push into the Stack
			int s = int.Parse(cmdArgs[1]); // s - represents the number of elements to pop from the Stack
			int x = int.Parse(cmdArgs[2]); // x - represents an element to look for in the Stack

			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			Stack<int> integers = new Stack<int>(numbers);

			for (int i = 0; i < s; i++)
			{
				integers.Pop();
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
