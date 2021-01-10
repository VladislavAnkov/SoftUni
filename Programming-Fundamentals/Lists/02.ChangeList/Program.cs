using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();

            string[] input = Console.ReadLine()
                             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .ToArray();

            while (input[0] != "end")
            {
                if (input[0] == "Delete")
                {
                    int numberToDelete = int.Parse(input[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == numberToDelete)
                        {
                            numbers.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    int element = int.Parse(input[1]);
                    int position = int.Parse(input[2]);

                    numbers.Insert(position, element);
                }

                input = Console.ReadLine()
                              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                              .ToArray();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
