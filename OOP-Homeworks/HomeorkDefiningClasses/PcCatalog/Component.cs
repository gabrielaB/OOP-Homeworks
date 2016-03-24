using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcCatalog
{
   public class Component
   {
       private string name;
       private decimal price;
       private string details;

       public Component(string name,decimal price) : this(name,price,null)
       {
            
       }

       public Component(string name,decimal price,string details)
       {
           this.Name = name;
           this.Price = price;
           this.Details = details;
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
                       throw new ArgumentException("Value can not be empty");
                   }
               }

               this.name = value;
           }
       }

       public decimal Price
       {
           get { return this.price; }
           set
           {
               if (value < 0)
               {
                   throw  new ArgumentException("Value can not be negative");
               }
               this.price = value;

           }
       }

       public string Details
       {
           get { return this.details; }
           set
           {
               if (value != null)
               {
                   value = value.Trim();
                   if (value == "")
                   {
                       throw new ArgumentException("Value can not be empty");
                   }
               }
               this.details = value;
           }
          
           }

       public override string ToString()
       {
           string output = string.Format("Component Name : {0}. Details : {1}. Price : {2}\n", this.Name,
               this.Details ?? "no details", this.Price);
           return output;
       }
   }
   }

