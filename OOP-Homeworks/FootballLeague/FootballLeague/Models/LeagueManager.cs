using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Models
{
    class LeagueManager
    {

        public static void HandleInput(string line)
        {
            var inputArgs = line.Split();
            switch (inputArgs[0])
            {
                case
                    "AddTeam":League.AddTeams(inputArgs[1],inputArgs[2],DateTime.Parse(inputArgs[3]));
                    break;
                case "AddMatch":League.AddMatch(inputArgs[1],inputArgs[2],DateTime.Parse(inputArgs[3]),inputArgs[4],inputArgs[5],DateTime.Parse(inputArgs[6]),int.Parse(inputArgs[7]),int.Parse(inputArgs[8]),int.Parse(inputArgs[9]));
                    break;
                case "AddPlayerToTeam":League.AddPlayerToTeam(inputArgs[1],inputArgs[2],decimal.Parse(inputArgs[3]),DateTime.Parse(inputArgs[4]),inputArgs[5],inputArgs[6], DateTime.Parse(inputArgs[7]));
                    break;     
                case "ListTeams":
                    League.ListTeams();
                    break;
                case "ListMatches":
                    League.ListMatches();
                    break;


            }
        }
    }
}
