using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace PcCatalog
{
   public class Computer
    {
        private string name;
        private ICollection<Component> components;
        private decimal price;

       public Computer(string name,ICollection<Component> components)
       {
           this.Name = name;
           this.Components = components;
            this.Price = components.Sum(c => c.Price);
        }

       public string Name
       {
           get { return this.name; }
           set
           {
               if (value == null)
               {
                   throw new ArgumentException("Value can not be null");

               }
               else
               {
                   value = value.Trim();
                   if (value == "")
                   {
                       throw  new ArgumentException("Value can not be empty");
                   }
               }
            
               this.name = value;
           }
       }

       public ICollection<Component> Components
       {
           get { return this.components; }
           set
           {
               if (value.Count == 0)
               {
                   throw  new ArgumentException("The computer must have at least one component");
               }
               this.components = value;
           }
       }

       public decimal Price { get; set; }

       public override string ToString()
       {
           string output = string.Format("Computer Name : {0}\n",this.Name);
           foreach (var component in this.Components)
           {
               output += component;
           }
           output += string.Format("Total Price : {0:F2}\n", this.Price);
           return output;
       }
    }
}
