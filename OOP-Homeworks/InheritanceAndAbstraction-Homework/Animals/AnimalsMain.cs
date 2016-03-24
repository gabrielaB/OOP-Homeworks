using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Animals;

namespace Animals
{
    class AnimalsMain
    {
        static void Main(string[] args)
        {
           Animal[] animals = new Animal[]
           {
               new Dog("Archi",7,Gender.Male), 
               new Frog("Jabcho",2,Gender.Male), 
               new Dog("Zuma",14,Gender.Female),
               new Frog("Jabka",1,Gender.Female),  
               new Kitten("Bela",7), 
               new TomCat("Tom",12), 
           };
            List<Dog> dogs=new List<Dog>();
            List<Cat> cats= new List<Cat>();
            List<Frog> frogs = new List<Frog>();

            foreach (var animal in animals)
            {
                switch (animal.GetType().Name)
                {
                    case "Dog":dogs.Add((Dog)animal);
                        break;
                    case "Frog":frogs.Add((Frog)(animal));
                        break;
                    default:cats.Add((Cat)(animal));
                        break;
                 }
            }

            Console.WriteLine("Dogs average age : {0:F2}", dogs.Average(d=> d.Age));
            Console.WriteLine("Frogs average age : {0:F2}", frogs.Average(f => f.Age));
            Console.WriteLine("Cats average age : {0:F2}", cats.Average(c => c.Age));


        }
    }
}
