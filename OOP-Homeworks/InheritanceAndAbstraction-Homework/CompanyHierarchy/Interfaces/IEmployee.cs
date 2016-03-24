using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Employees;

namespace CompanyHierarchy.Interfaces
{
    public interface IEmployee
    {
         decimal Salary { get; set; }
         Department Department { get; set; }
    }
}
