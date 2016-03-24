using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;
using Microsoft.SqlServer.Server;

namespace CompanyHierarchy.Employees.RegularEmployees
{
    public class Sale:ISales
    {
        private string productName;
        private decimal price ;
        private DateTime date;

        public Sale(string productName,decimal price,DateTime date)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Date = date;

        }

        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
