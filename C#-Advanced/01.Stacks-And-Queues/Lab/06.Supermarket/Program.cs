using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
			string input = Console.ReadLine();

			Queue<string> clients = new Queue<string>();

			while (input != "End")
			{
				if (input != "Paid")
				{
					clients.Enqueue(input);
				}
				else
				{
					int n = clients.Count;
					for (int i = 0; i < n; i++)
					{
						Console.WriteLine(clients.Dequeue());
					}
				}

				input = Console.ReadLine();
			}

			Console.WriteLine("{0} people remaining.", clients.Count);
		}
    }
}
