using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Employees.RegularEmployees;

namespace CompanyHierarchy.Interfaces
{
   public interface ISalesEmployee
    {
      IEnumerable<Sale> Sales { get; set; }
    }
}
