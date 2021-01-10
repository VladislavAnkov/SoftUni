using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfPeople = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string namePattern = @"[\W\d]";
            string distancePattern = @"[A-z\W]";

            Dictionary<string, int> athletes = new Dictionary<string, int>();

            for (int i = 0; i < listOfPeople.Count; i++)
            {
                if (!athletes.ContainsKey(listOfPeople[i]))
                {
                    athletes.Add(listOfPeople[i], 0);
                }
            }

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = Regex.Replace(input, namePattern, "");
                string distance = Regex.Replace(input, distancePattern, "");

                int sum = 0;

                for (int i = 0; i < distance.Length; i++)
                {
                    int currentNum = int.Parse(distance[i].ToString());
                    sum += currentNum;
                }

                if (athletes.ContainsKey(name))
                {
                    athletes[name] += sum;
                }

                input = Console.ReadLine();
            }

            int count = 1;

            foreach (var athlete in athletes.OrderByDescending(x => x.Value))
            {
                string output = count == 1 ? "st" : count == 2 ? "nd" : "rd";

                Console.WriteLine($"{count++}{output} place: {athlete.Key}");

                if (count == 4)
                {
                    break;
                }
            }


        }
    }
}
