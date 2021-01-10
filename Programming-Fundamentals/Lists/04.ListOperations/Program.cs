using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split().ToArray();
                string manipulation = cmdArgs[0];

                if (manipulation == "Add")
                {
                    numbers.Add(int.Parse(cmdArgs[1]));
                }
                else if (manipulation == "Insert")
                {
                    if (int.Parse(cmdArgs[2]) > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int number = int.Parse(cmdArgs[1]);
                        int index = int.Parse(cmdArgs[2]);

                        numbers.Insert(index, number);
                    }
                }
                else if (manipulation == "Remove")
                {
                    if (int.Parse(cmdArgs[1]) > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int index = int.Parse(cmdArgs[1]);
                        numbers.RemoveAt(index);
                    }
                }
                else if (manipulation == "Shift")
                {
                    int rotation = int.Parse(cmdArgs[2]);

                    if (cmdArgs[1] == "left")
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int firstElement = numbers[0];
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }

                            numbers[numbers.Count - 1] = firstElement;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int lastElement = numbers[numbers.Count - 1];

                            for (int j = numbers.Count - 1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];
                            }

                            numbers[0] = lastElement;
                        }
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
