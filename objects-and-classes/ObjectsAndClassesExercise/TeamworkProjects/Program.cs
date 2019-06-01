using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Team
    {
        public string TeamName { get; set; }
        public List<string> Members = new List<string>();
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            var input1 = Console.ReadLine().Split('-').ToArray();

            for (int i = 0; i < n; i++)
            {
                var user = input1[0];
                var team = input1[1];

                var canAdd = true;
                if (teams.Any(x => x.Name == user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                    canAdd = false;
                }

                foreach (var teamName in teams)
                {
                    if (teamName.Members.Contains(team))
                    {
                        Console.WriteLine($"Team {team} was already created!");
                        canAdd = false;
                    }
                }

                if (canAdd == true)
                {
                    var newTeam = new Team()
                    {
                        TeamName = team,
                        Name = user,
                        Members = new List<string>()
                    };
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {team} has been created by {user}!");
                }

                input1 = Console.ReadLine().Split('-').ToArray();
            }

            var input2 = Console.ReadLine().Split("->").ToArray();

            while (input2[0] != "end of assignment")
            {
                var user = input2[0];
                var team = input2[1];

                var doesExist = false;
                var isSwitch = false;

                foreach (var teamName in teams)
                {
                    if (teamName.Members.Contains(team))
                    {
                        doesExist = true;
                    }
                    if (teamName.Members.Contains(user))
                    {
                        isSwitch = true;
                    }
                }

                if (doesExist == false && isSwitch == false)
                {
                    foreach (var adder in teams)
                    {
                        if (adder.TeamName == team)
                        {
                            adder.Members.Add(user);
                        }
                    }
                }
                else if (doesExist == true)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (isSwitch == true)
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                }

                input2 = Console.ReadLine().Split(new char[] { '-', '>' }).ToArray();
            }

            var teamsToDisband = new List<string>();
            foreach (var teamName in teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName))
            {
                Console.WriteLine($"{teamName.TeamName}");
                var dashes = 1;
                foreach (var teamMembers in teams)
                {
                    if (teamMembers.Members.Count == 0)
                    {
                        teamsToDisband.Add(teamMembers.TeamName);
                    }
                    Console.WriteLine($"{new String('-', dashes)} {teamMembers.Members}");
                    dashes = 2;
                }
            }

            foreach (var disbandedTeams in teamsToDisband)
            {
                Console.WriteLine($"{disbandedTeams}");
            }
        }
    }
}
