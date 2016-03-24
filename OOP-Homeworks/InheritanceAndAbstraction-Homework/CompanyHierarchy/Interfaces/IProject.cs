using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Employees.RegularEmployees;

namespace CompanyHierarchy.Interfaces
{
   public interface IProject
    {
      string ProjectName { get; set; }
      DateTime ProjectStartDate { get; set; }
      string Details { get; set; }
      State State { get; set; }

       void ClosedProject();

    }
}
