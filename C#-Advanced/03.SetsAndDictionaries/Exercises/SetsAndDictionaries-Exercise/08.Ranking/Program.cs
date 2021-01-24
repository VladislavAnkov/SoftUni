using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> contests = new Dictionary<string, string>();

            while (input != "end of contests")
            {
                var tokens = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = tokens[0];
                string password = tokens[1];

                contests.Add(contest, password);

                input = Console.ReadLine();
            }

            string submissions = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> students = new SortedDictionary<string, Dictionary<string, int>>();

            while (submissions != "end of submissions")
            {
                var tokens = submissions.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string currentContest = tokens[0];
                string currentPass = tokens[1];
                string student = tokens[2];
                int currentPoints = int.Parse(tokens[3]);

                if (contests.ContainsKey(currentContest) && contests[currentContest] == currentPass)
                {
                    if (!students.ContainsKey(student))
                    {
                        students.Add(student, new Dictionary<string, int>());
                        students[student].Add(currentContest, currentPoints);
                    }
                    else
                    {
                        if (students[student].ContainsKey(currentContest) && students[student][currentContest] < currentPoints)
                        {
                            students[student][currentContest] = currentPoints;
                        }
                        else if (!students[student].ContainsKey(currentContest))
                        {
                            students[student].Add(currentContest, currentPoints);
                        }
                    }
                }

                submissions = Console.ReadLine();
            }

            KeyValuePair<string, Dictionary<string, int>> bestCandidate = 
                students.OrderByDescending(kvp => kvp.Value.Values.Sum()).First();
            int totalPoints = bestCandidate.Value.Values.Sum();

            Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {totalPoints} points." + "\nRanking:");

            foreach (KeyValuePair<string, Dictionary<string, int>> student in students)
            {
                Console.WriteLine(student.Key);

                foreach (KeyValuePair<string, int> contest in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
            
        }
    }
}
