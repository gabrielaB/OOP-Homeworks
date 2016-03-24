using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Customers
{
   public class Customer :Person,ICustomer
   {
       private decimal moneySpent;

        public Customer(int id, string firstName, string lastName,decimal moneySpent) : base(id, firstName, lastName)
        {
            this.MoneySpent = moneySpent;
        }

        public decimal MoneySpent { get; set; }

       public override string ToString()
       {
           return string.Format(this.FirstName)
       }
   }
}
