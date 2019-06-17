using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Team
    {
        public string TeamName { get; set; }
        public List<string> Members = new List<string>();
        public string CreatorName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                var creatorAndTeam = Console.ReadLine().Split('-').ToList();
                CreateTeam(creatorAndTeam, teams);
            }

            var memberToTeam = Console.ReadLine().Split(new string[] { "->" }, StringSplitOptions.None).ToList();

            while (memberToTeam[0] != "end of assignment")
            {
                AddMembers(memberToTeam, teams);

                memberToTeam = Console.ReadLine().Split(new string[] { "->" }, StringSplitOptions.None).ToList();
            }

            PrintTeams(teams);
        }

        public static List<Team> CreateTeam(List<string> creatorAndTeam, List<Team> teams)
        {
            var creatorName = creatorAndTeam[0];
            var teamName = creatorAndTeam[1];
            var team = new Team();

            if (teams.Any(x => x.TeamName == teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
                return teams;
            }
            else if (teams.Any(x => x.CreatorName == creatorName))
            {
                Console.WriteLine($"{creatorName} cannot create another team!");
                return teams;
            }

            team.TeamName = teamName;
            team.CreatorName = creatorName;

            teams.Add(team);

            Console.WriteLine($"Team {teamName} has been created by {creatorName}!");

            return teams;
        }

        public static List<Team> AddMembers(List<string> memberToTeam, List<Team> teams)
        {
            var memberName = memberToTeam[0];
            var teamName = memberToTeam[1];

            if (!teams.Any(x => x.TeamName == teamName))
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                return teams;
            }
            else if (teams.Any(x => x.Members.Contains(memberName)) || teams.Any(x => x.CreatorName == memberName))
            {
                Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                return teams;
            }

            teams.Single(x => x.TeamName == memberToTeam[1]).Members.Add(memberName);

            return teams;
        }

        public static void PrintTeams(List<Team> teams)
        {
            var orderedTeams = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName).ToList();
            var printTeams = orderedTeams.Where(x => x.Members.Count > 0).ToList();
            foreach (var team in printTeams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.CreatorName}");
                foreach (var members in team.Members.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {members}");
                }
            }

            var teamsToDisband = orderedTeams.Where(x => x.Members.Count == 0).ToList();
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}
