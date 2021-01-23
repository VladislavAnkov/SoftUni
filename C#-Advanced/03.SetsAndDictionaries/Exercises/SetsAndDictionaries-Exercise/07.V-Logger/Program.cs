using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] vloggerData = Console.ReadLine().Split();

			Dictionary<string, Dictionary<string, HashSet<string>>> vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

			while (true)
			{
				if (vloggerData[0] == "Statistics")
				{
					break;
				}
				string command = vloggerData[1];
				string currentVlogger = vloggerData[0];

				if (command == "joined" && !vloggers.ContainsKey(currentVlogger))
				{
					vloggers.Add(currentVlogger, new Dictionary<string, HashSet<string>>());
					vloggers[currentVlogger].Add("following", new HashSet<string>());
					vloggers[currentVlogger].Add("followers", new HashSet<string>());
				}
				else if (command == "followed")
				{
					string secondVlogger = vloggerData[2];

					if (!vloggers.ContainsKey(currentVlogger) || !vloggers.ContainsKey(secondVlogger) || currentVlogger == secondVlogger)
					{
						vloggerData = Console.ReadLine().Split();
						continue;
					}
					else
					{
						vloggers[currentVlogger]["following"].Add(secondVlogger);
						vloggers[secondVlogger]["followers"].Add(currentVlogger);
					}
				}

				vloggerData = Console.ReadLine().Split();
			}

			int number = 1;

			Console.WriteLine($"The V-Logger has a total of {vloggers.Keys.Count} vloggers in its logs.");

			foreach (KeyValuePair<string, Dictionary<string, HashSet<string>>> kvp in vloggers.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count))
			{
				Console.WriteLine($"{number}. {kvp.Key} : {kvp.Value["followers"].Count} followers, {kvp.Value["following"].Count} following");

				if (number == 1)
				{
					foreach (var follower in kvp.Value["followers"].OrderBy(x => x))
					{
						Console.WriteLine($"*  {follower}");
					}
				}

				number++;
			}

		}
	}
}
