using System;

namespace FootballLeague.Models
{
    public class Score
    {
        private int homeTeamGoals;
        private int awayTeamGoals;

        public Score(int homeTeamGoals, int awayTeamGoals)
        {
            this.HomeTeamGoals = homeTeamGoals;
            this.AwayTeamGoals = awayTeamGoals;
        }

        public int HomeTeamGoals
        {
            get
            {
                return this.homeTeamGoals;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Goals can not be negative");
                }
                this.homeTeamGoals = value;
            }
        }

        public int AwayTeamGoals
        {
            get
            {
                return this.awayTeamGoals;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Goals can not be negative");
                }
                this.awayTeamGoals = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.HomeTeamGoals, this.AwayTeamGoals);
        }
    }
}