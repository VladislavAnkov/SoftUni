using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();

            string[] cmd = Console.ReadLine().Split(" - ");

            while (cmd[0] != "Craft!")
            {
                string command = cmd[0];
                string item = cmd[1];

                if (command == "Collect")
                {
                    if (!journal.Contains(item))
                    {
                        journal.Add(item);
                    }
                }
                else if (command == "Drop")
                {
                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                    }
                }
                else if (command == "Combine Items")
                {
                    string[] splittedItems = item.Split(":");
                    string oldItem = splittedItems[0];
                    string newItem = splittedItems[1];

                    if (journal.Contains(oldItem))
                    {
                        int index = journal.FindIndex(x => x == oldItem);
                        journal.Insert(index + 1, newItem);
                        
                    }
                }
                else if (command == "Renew")
                {
                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                        journal.Add(item);
                    }
                }

                cmd = Console.ReadLine().Split(" - ");
            }

            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
