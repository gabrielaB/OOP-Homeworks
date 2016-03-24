using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
   public abstract class Cat : Animal
    {
       public Cat(string name,int age,Gender gender) : base(name,age,gender)
       {
           
       }

       public override void ProduceSound()
       {
           Console.WriteLine("Mquu");
       }
    }
}
