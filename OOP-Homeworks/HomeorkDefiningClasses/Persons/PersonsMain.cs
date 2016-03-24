using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class PersonsMain
    {
        static void Main(string[] args)
        {
            Person first = new Person("Ivan", 66);
            Person second = new Person("ddd", 77, "ddd@dd.bg");
            Person[] persons = new Person[] { first, second };

            foreach (Person  person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
