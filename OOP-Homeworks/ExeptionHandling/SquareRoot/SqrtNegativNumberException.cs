using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
     public class SqrtNegativNumberException : Exception
    {
         public SqrtNegativNumberException(string message = "Square root operation can not work with negative numbers") : base(message)
         {
             
         }
    }
}
