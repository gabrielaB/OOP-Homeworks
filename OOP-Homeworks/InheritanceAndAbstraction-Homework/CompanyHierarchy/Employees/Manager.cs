using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Employees;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Employees
{
    public class Manager : Employee,IManager
    {
        private IEnumerable<Employee> employees;

        public Manager(int id, string firstName, string lastName, decimal salary, Department department,IEnumerable<Employee> emplo
            ) : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public IEnumerable<Employee> Employees { get; set; }

        
    }
}
