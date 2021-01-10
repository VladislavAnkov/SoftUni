using System;
using System.Linq;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>(numberOfCommands);

            for (int i = 0; i < numberOfCommands; i++)
            {
                string input = Console.ReadLine();

                if (input.Contains("not"))
                {
                    string name = input.Substring(0, input.IndexOf(' '));
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    string name = input.Substring(0, input.IndexOf(' '));

                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
            }

            foreach(string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
