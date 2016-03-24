using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title,string author,decimal price) : base (title,author,price)
        {
            
        }

        protected override decimal Price
        {
            get { return this.price * 1.3m; }
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
