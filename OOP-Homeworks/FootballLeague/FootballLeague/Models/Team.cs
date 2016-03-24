using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballLeague.Models
{
    public class Team
    {
        private const int MinimumYear = 1850;
        private string name;
        private string nickname;
        private DateTime dateOfFounding;
        private List<Player> players;

        public Team(string name, string nickname, DateTime dateOfFounding)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.DateOfFounding = dateOfFounding;
            this.players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name of the team can not be null");
                }
                
                value = value.Trim();
                if (value.Length < 5)
                {
                    throw new ArgumentException("The name of the team must be at least 5 characters long");
                }
                
                this.name = value;
            }
        }

        public string Nickname
        {
            get
            {
                return this.nickname;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The nickname of the team can not be null");
                }

                value = value.Trim();
                if (value.Length < 5)
                {
                    throw new ArgumentException("The nickname of the team must be at least 5 characters long");
                }

                this.nickname = value;
            }
        }

        public DateTime DateOfFounding
        {
            get { return this.dateOfFounding; }
            set
            {
                if (value.Year <= MinimumYear)
                {
                    throw  new ArgumentException("The year should be after " + MinimumYear);
                }
                this.dateOfFounding = value;
            }
        }

        public IEnumerable<Player> Players
        {
            get
            {
                return this.players;
            }
            
        
        }

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("Player alreay exists for that team");
            }
            this.players.Add(player);
        }

        private bool CheckIfPlayerExists(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName);
        }

        public override string ToString()
        {
            string output = string.Format("Team name: {0},Date of founding: {1}", this.Name, this.DateOfFounding);
            return output;
        }
    }
}