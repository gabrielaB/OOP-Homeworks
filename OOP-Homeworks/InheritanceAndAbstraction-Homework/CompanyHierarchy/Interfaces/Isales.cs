using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Interfaces
{
    public interface ISales
    {
         string ProductName { get; set; }
         decimal Price { get; set; }
         DateTime Date { get; set; }
    }
}
