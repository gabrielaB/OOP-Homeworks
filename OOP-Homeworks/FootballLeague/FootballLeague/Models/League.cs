using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Models
{
    public static class League
    {
        private static List<Match> matches= new List<Match>();
        private static List<Team> teams = new List<Team>();


        public static IEnumerable<Match> Matches
        {
            get { return League.matches; }
        }

        public static IEnumerable<Team> Teams
        {
            get { return League.teams; }
        }

        public static void AddMatch(string homeTeamName,string homeTeamNickName,DateTime homeTeamDate, string awayTeamName,string awayTeamNickname,DateTime awayTeamDate,int homeTeamGoals,int awayTeamGoals,int id)
        { 
            Team homeTeam = new Team(homeTeamName,homeTeamNickName,homeTeamDate);
            Team awayTeam= new Team(awayTeamName,awayTeamNickname,awayTeamDate);
            Score score = new Score(homeTeamGoals,awayTeamGoals);
            Match currentMatch = new Match(homeTeam,awayTeam,score,id);
            if (CheckMatchesId(currentMatch))
            {
                throw new InvalidOperationException("There can not be matches with equal ID");
            }
            League.matches.Add(currentMatch);
            Console.WriteLine("Match has been added");
        }

        private static bool CheckMatchesId(Match match)
        {
            return matches.Any(m => m.Id == match.Id);
        }
        public static void AddTeams(string name,string nickname,DateTime dateOfFounding)
        {
            Team currentTeam=new Team(name,nickname,dateOfFounding);
            if (CheckTeamsNames(currentTeam))
            {
                throw new InvalidOperationException("There can not be teams with the same names");
            }
            League.teams.Add(currentTeam);
            Console.WriteLine("Team {0} has been added",name);
        }
        private static bool CheckTeamsNames(Team team)
        {
            return teams.Any(t => t.Name == team.Name);
        }

        public static void AddPlayerToTeam(string firstName, string lastName, decimal salary, DateTime dateOfBirth,string teamName,string teamNickname,DateTime teamDate)
            
        {
            Team team = new Team(teamName,teamNickname,teamDate);
            Player currentPlayer = new Player(firstName,lastName,salary,dateOfBirth,team);
            team.AddPlayer(currentPlayer);
            Console.WriteLine("Player has been added");
        }

        public static void ListMatches()
        {
            foreach (var match in League.Matches)
            {
                Console.WriteLine(match);
            }
        }

        public static void ListTeams()
        {
            foreach (var team in League.Teams)
            {
                Console.WriteLine(team);
            }    
        }
    }
}
