using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Employees.RegularEmployees;

namespace CompanyHierarchy.Interfaces
{
    public interface IDeveloper
    {
      IEnumerable<Project> Projects { get; set; }
    }
}
