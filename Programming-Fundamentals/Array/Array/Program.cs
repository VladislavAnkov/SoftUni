using System;
using System.Linq;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            int[] arr = line
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
