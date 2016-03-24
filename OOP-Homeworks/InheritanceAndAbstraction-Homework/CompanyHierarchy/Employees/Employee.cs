using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Employees
{
   public abstract class Employee : Person,IEmployee
   {
       private decimal salary;
       private Department department;

        public Employee(int id, string firstName, string lastName,decimal salary,Department department) : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;

        }

        public decimal Salary { get; set; }
       public Department Department { get; set; }

      
   }
}
