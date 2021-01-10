using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!").ToList();

            string command;

            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] cmdArgs = command.Split().ToArray();

                string action = cmdArgs[0];
                string item = cmdArgs[1];

                bool isInList = groceries.Contains(item);

                if (action == "Urgent")
                {
                    if (!isInList)
                    {
                        groceries.Insert(0, item);
                    }
                }
                else if (action == "Unnecessary")
                {
                    if (isInList)
                    {
                        groceries.Remove(item);
                    }
                }
                else if (action == "Correct")
                {
                    if (isInList)
                    {
                        int index = groceries.IndexOf(item);
                        string newItem = cmdArgs[2];
                        groceries[index] = newItem;
                    }
                }
                else if (action == "Rearrange")
                {
                    if (isInList)
                    {
                        groceries.Remove(item);
                        groceries.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
