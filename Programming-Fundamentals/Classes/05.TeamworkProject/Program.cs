using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.TeamworkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();



            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("-");

                string teamName = input[1];
                string creator = input[0];

                Team team = new Team(teamName, creator);

                if (i == 0)
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }

                bool hasCreatedList = teams.Any(n => n.Creator == creator);
                bool isInList = teams.Any(n => n.TeamName == teamName);

                if ((!isInList) && i > 0)
                {
                    if (!hasCreatedList)
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                    else if (hasCreatedList)
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                }
                else if (isInList && i > 0)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }

            }

            string[] command = Console.ReadLine().Split("->");

            while (command[0] != "end of assignment")
            {
                string user = command[0];
                string teamToJoin = command[1];


                if (!teams.Select(x => x.TeamName).Contains(teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (teams.Select(x => x.Members).Any(a => a.Contains(user)) ||
                         teams.Select(x => x.Creator).Contains(user))

                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                }
                else
                {
                    int index = teams.FindIndex(a => a.TeamName == teamToJoin);
                    teams[index].Members.Add(user);
                }


                command = Console.ReadLine().Split("->");
            }

            Team[] teamsToDisband = teams.OrderBy(x => x.TeamName)
                                         .Where(a => a.Members.Count == 0)
                                         .ToArray();

            Team[] teamsWithMembers = teams.OrderByDescending(x => x.Members.Count)
                                           .ThenBy(x => x.TeamName)
                                           .Where(a => a.Members.Count > 0)
                                           .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (Team team in teamsWithMembers)
            {
                sb.AppendLine($"{team.TeamName}");
                sb.AppendLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x=>x))
                {
                    sb.AppendLine($"-- {member}");
                }
            }

            sb.AppendLine($"Teams to disband:");

            foreach (Team item in teamsToDisband)
            {
                sb.AppendLine(item.TeamName);
            }

            Console.WriteLine(sb.ToString());
        }
    }

    class Team
    {
        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Members = new List<string>();
        }
    }

}
