using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRootMain
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    throw new SqrtNegativNumberException();
                }
                Console.WriteLine(Math.Sqrt(n));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (SqrtNegativNumberException)
            {
                Console.WriteLine("Number can not be negavite");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }



        }
    }
}
