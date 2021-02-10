using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PartyReservationFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peopleInvited = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> startsFilter = new List<string>();
            List<string> endsFilter = new List<string>();
            List<string> lengthFilter = new List<string>();
            List<string> containsFilter = new List<string>();

            string[] commandArgs = Console.ReadLine().Split(";");

            while (commandArgs[0] != "Print")
            {
                string command = commandArgs[0];
                string criteria = commandArgs[1];
                string parameter = commandArgs[2];

                if (command == "Add filter")
                {
                    if (criteria == "Starts with")
                    {
                        startsFilter.Add(parameter);
                    }
                    else if (criteria == "Ends with")
                    {
                        endsFilter.Add(parameter);
                    }
                    else if (criteria == "Contains")
                    {
                        containsFilter.Add(parameter);
                    }
                    else if (criteria == "Length")
                    {
                        lengthFilter.Add(parameter);
                    }
                }
                else if (command == "Remove filter")
                {
                    if (criteria == "Starts with")
                    {
                        startsFilter.Remove(parameter);
                    }
                    else if (criteria == "Ends with")
                    {
                        endsFilter.Remove(parameter);
                    }
                    else if (criteria == "Contains")
                    {
                        containsFilter.Remove(parameter);
                    }
                    else if (criteria == "Length")
                    {
                        lengthFilter.Remove(parameter);
                    }
                }

                commandArgs = Console.ReadLine().Split(";");
            }

            Predicate<string> predicate = null;

            if (startsFilter.Any())
            {
                foreach (string filter in startsFilter)
                {
                    peopleInvited.RemoveAll(x => x.StartsWith(filter));
                }
            }

            if (endsFilter.Any())
            {
                foreach (string filter in endsFilter)
                {
                    peopleInvited.RemoveAll(x => x.EndsWith(filter));
                }
            }

            if (containsFilter.Any())
            {
                foreach (string filter in containsFilter)
                {
                    peopleInvited.RemoveAll(x => x.Contains(filter));
                }
            }

            if (lengthFilter.Any())
            {
                foreach (string  filter in lengthFilter)
                {
                    int length = int.Parse(filter);
                    peopleInvited.RemoveAll(x => x.Length == length);
                }
            }

            Console.WriteLine(string.Join(" ", peopleInvited));
        }
    }
}
