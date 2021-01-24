using System;
using System.Collections.Generic;

namespace _05.RecorUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueNames = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentName = Console.ReadLine();

                uniqueNames.Add(currentName);
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
