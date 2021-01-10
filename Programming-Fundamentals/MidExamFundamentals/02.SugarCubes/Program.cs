using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SugarCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cubes = Console.ReadLine()
                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Mort")
            {
                string[] cmdArgs = input.Split();

                string command = cmdArgs[0];
                int value = int.Parse(cmdArgs[1]);

                if (command == "Add")
                {
                    cubes.Add(value);
                }
                else if (command == "Remove")
                {
                    cubes.Remove(value);
                }
                else if (command == "Replace")
                {
                    int replacement = int.Parse(cmdArgs[2]);

                    int index = cubes.IndexOf(value);
                    cubes[index] = replacement;
                }
                else if (command == "Collapse")
                {
                    cubes.RemoveAll(x => x < value);
                }
            }

            Console.WriteLine(string.Join(" ", cubes));
        }
    }
}
