using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingWithAbstraction.Characters;

namespace WorkingWithAbstraction
{
    class AbstractionMain
    {
        static void Main(string[] args)
        {
            Warrior first =new Warrior();
            Priest second = new Priest();

            while (true)
            {
                Console.WriteLine("First atack");
                first.Attack(second);
                Console.WriteLine(string.Format("First {0} health, Second {1} health", first.Health > 0 ? first.Health : 0, second.Health > 0 ? second.Health : 0));

                if (second.Health <= 0)
                {
                    Console.WriteLine(first.GetType().Name + " won");
                    break;
                }
               
                Console.WriteLine("Second atack");

                second.Attack(first);
                Console.WriteLine(string.Format("First {0} health, Second {1} health", first.Health > 0 ? first.Health : 0, second.Health > 0 ? second.Health : 0));
                if (first.Health <= 0)
                {
                Console.WriteLine(second.GetType().Name + " won");

                    break;
                }

            }

          
        }
    }
}
