using System;
using System.Collections.Generic;

namespace _07.HotPotatoe
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] input = Console.ReadLine().Split();

			Queue<string> kids = new Queue<string>(input);

			int n = int.Parse(Console.ReadLine());

			int count = 1;

			while (kids.Count > 1)
			{
				if (count == n)
				{
					Console.WriteLine("Removed " + kids.Dequeue());
					count = 1;
				}
				else
				{
					kids.Enqueue(kids.Dequeue());
					count++;
				}
			}

			Console.WriteLine("Last is " + kids.Dequeue());
		}
    }
}
