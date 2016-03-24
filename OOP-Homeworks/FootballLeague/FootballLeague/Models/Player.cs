﻿using System;

namespace FootballLeague.Models
{
    public class Player
    {
        private const int MinimumAllowedYear = 1980;
        private string firstName;
        private string lastName;
        private decimal salary;
        private DateTime dateOfBirth;
        private Team team;     

        public Player(string firstName, string lastName, decimal salary, DateTime dateOfBirth, Team team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.DateOfBirth = dateOfBirth;
            this.Team = team;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("The First name should be at least 3 characters long");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("The Last name should be at least 3 characters long");
                }
                this.lastName = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary can not be negative");
                }
                this.salary = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }
            set
            {
                if (value.Year < MinimumAllowedYear)
                {  
                    throw new ArgumentException("The year of birth should be not earlier than " + MinimumAllowedYear);
                }
                this.dateOfBirth = value;
            }
        }

        public Team Team { get; set; }
    }
}