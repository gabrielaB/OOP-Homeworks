using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
     public class Book
     {
         protected string title;
         protected string author;
         protected decimal price;

         public Book(string title,string author,decimal price)
         {
             this.Title = title;
             this.Author = author;
             this.Price = price;
         }

        protected string Title
        {
             get { return this.title; }
             set
             {
                 if (string.IsNullOrWhiteSpace(value))
                 {
                     throw  new ArgumentException("Title can not be null or empty");
                 }
                 this.title = value;
             }
        }

        protected string Author
         {
             get { return this.author; }
             set
             {
                 if (string.IsNullOrWhiteSpace(value))
                 {
                     throw new ArgumentException("Author can not be null or empty");
                 }
                 this.author = value;
             }
         }

         protected virtual decimal Price
        {
             get { return this.price; }
             set
             {
                 if (value < 0)
                 {
                     throw  new ArgumentException("Price can not be negative");
                 }
                 this.price = value;

               }
         }

         public override string ToString()
         {
             string output = string.Format("-Type: {0}\n", this.GetType().Name);
             output += string.Format("-Title: {0}\n", this.Title);
             output += string.Format("-Author: {0}\n", this.Author);
             output += string.Format("-Price: {0:F2}\n", this.Price);
            return output;
             
         }
     }
}
