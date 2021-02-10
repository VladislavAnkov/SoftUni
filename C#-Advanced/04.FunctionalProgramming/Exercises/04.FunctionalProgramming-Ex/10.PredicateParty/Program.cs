using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0] != "Party!")
            {
                string command = cmdArgs[0];
                string criteria = cmdArgs[1];
                string letters = cmdArgs[2];

                if (command == "Remove")
                {
                    if (criteria == "StartsWith")
                    {
                        guests.RemoveAll(s => s.StartsWith(letters));
                    }
                    else if (criteria == "EndsWith")
                    {
                        guests.RemoveAll(s => s.EndsWith(letters));
                    }
                    else
                    {
                        int length = int.Parse(letters);
                        guests.RemoveAll(s => s.Length == length);
                    }
                }
                else if (command == "Double")
                {
                    Predicate<string> predicate = null;
                    if (criteria == "StartsWith")
                    {
                        predicate = new Predicate<string>(n => n.StartsWith(letters));
                        DoubleList(guests, predicate);

                    }
                    else if (criteria == "EndsWith")
                    {
                        predicate = new Predicate<string>(n => n.EndsWith(letters));
                        DoubleList(guests, predicate);
                    }
                    else
                    {
                        int length = int.Parse(letters);
                        predicate = new Predicate<string>(n => n.Length == length); 
                        DoubleList(guests, predicate);

                    }
                }
                cmdArgs = Console.ReadLine().Split();
            }

            if (guests.Any())
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
                
        }

        public static void DoubleList(List<string> guests, Predicate<string> predicate)
        {
            for (int i = 0; i < guests.Count; i++)
            {
                string currentGuest = guests[i];

                if (predicate(currentGuest))
                {
                    guests.Insert(i + 1, currentGuest);
                    i++;
                }
            }
        }


    }
}
