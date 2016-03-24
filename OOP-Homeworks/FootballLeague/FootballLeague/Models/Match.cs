using System;

namespace FootballLeague.Models
{
    public class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;

        public Match(Team homeTeam, Team awayTeam, Score score, int id)
        {
            if (homeTeam.Name == awayTeam.Name)
            {
                throw new ArgumentException("The team names can not be the same");
            }
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
            this.Id = id;
        }

        public Team HomeTeam
        {
            get
            {
                return this.homeTeam;
            }
            set
            {
                //if (awayTeam != null)
                //{
                //    if (value.Name == awayTeam.Name)
                //    {
                //        throw new ArgumentException("The teams should be different");
                //    }
                //}
                this.homeTeam = value;
            }
        }

        public Team AwayTeam
        {
            get
            {
                return this.awayTeam;
            }
            set
            {
                //if (homeTeam != null)
                //{
                //    if (value.Name == homeTeam.Name)
                //    {
                //        throw new ArgumentException("The teams should be different");
                //    }
                //}
                this.awayTeam = value;
            }
        }

        public Score Score { get; set; }

        public int Id
        {
            get
            {
                return this.id;               
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The id of the match can not be negative");
                }
                this.id = value;
            }
        }

        public Team GetWinner()
        {
            if (this.isDraw())
            {
                return null;
            }

            return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals ? this.HomeTeam : this.AwayTeam;
        }

        private bool isDraw()
        {
            return this.Score.HomeTeamGoals == this.Score.AwayTeamGoals;
        }

        public override string ToString()
        {
            string output=String.Format("Match info : id = {0}, {1} vs. {2} ({3})",this.Id,this.HomeTeam,this.AwayTeam,this.Score);
            return output;
        }
    }
}