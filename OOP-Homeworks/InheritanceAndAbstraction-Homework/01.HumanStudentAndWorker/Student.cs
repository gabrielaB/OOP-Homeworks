using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.HumanStudentAndWorker
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName,string lastName,string facultyNumber) : base(firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }
        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("The faculty number is invalid");
                }
                Regex regex = new Regex(@"\w+");
                Match match = regex.Match(value);
                if (value != match.ToString())
                {
                    throw new ArgumentException("Invalid faculty number");
                }
                this.facultyNumber = value;
            }

          }

        public override string ToString()
        {
            return string.Format("Name : {0}.Faculty number {1}", this.FirstName + " " + this.LastName,
                this.FacultyNumber);
        }
    }
}
