using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Employees.RegularEmployees
{
    public class Developer : RegularEmployee,IDeveloper
    {
        private IEnumerable<Project> projects;

        public Developer(int id, string firstName, string lastName, decimal salary, Department department,IEnumerable<Project> projects
            ) : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public IEnumerable<Project> Projects { get; set; }

        
    }
}
