using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
		static void Main(string[] args)
		{
			string[] songsInput = Console.ReadLine().Split(", ");

			Queue<string> songs = new Queue<string>(songsInput);

			string command = Console.ReadLine();

			while (true)
			{
				if (command.Substring(0, 3) == "Add")
				{
					string songName = command.Substring(4, command.Length - 4);
					if (!songs.Contains(songName))
					{
						songs.Enqueue(songName);
					}
                    else
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
				}
				else if (command == "Play" && songs.Any())
				{
					songs.Dequeue();
				}
				else if (command == "Show" && songs.Any())
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

				command = Console.ReadLine();

				if (!songs.Any())
				{
					Console.WriteLine("No more songs!");
					break;
				}
			}


		}
    }
}
