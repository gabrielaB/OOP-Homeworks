using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentAndWorker
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workingHoursPerDay;

        public Worker(string firstName,string lastName,decimal weekSalary,int workingHoursPerDay) : base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHoursPerDay = workingHoursPerDay;
        }
        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value","Salary can not be negative");
                }
                this.weekSalary = value;
            }
        }
        public int  WorkingHoursPerDay
        {
            get { return this.workingHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Working hours can not be negative");
                }
                this.workingHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary/(this.WorkingHoursPerDay*5);
        }

        public override string ToString()
        {
            return string.Format("Name : {0}.Money per hour : {1:F2}", this.FirstName + " " + this.LastName,
                this.MoneyPerHour());
        }
    }
}
