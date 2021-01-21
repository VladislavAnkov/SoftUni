using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());

			SortedSet<string> elements = new SortedSet<string>();

			for (int i = 0; i < n; i++)
			{
				string[] chemicals = Console.ReadLine().Split();

				for (int k = 0; k < chemicals.Length; k++)
				{
					string currentElement = chemicals[k];
					elements.Add(currentElement);
				}
				Console.WriteLine();
			}

			foreach (string element in elements)
			{
				Console.Write(element + " ");
			}
		}
    }
}
