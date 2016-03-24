using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Employees.RegularEmployees
{
   public class SalesEmployee : RegularEmployee, ISalesEmployee
   {
       private IEnumerable<Sale> sales;

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department department,IEnumerable<Sale> sales ) : base(id, firstName, lastName, salary, department)
        {
            this.Sales = this.sales;
        }

        public IEnumerable<Sale> Sales { get; set; }

       
   }
}
