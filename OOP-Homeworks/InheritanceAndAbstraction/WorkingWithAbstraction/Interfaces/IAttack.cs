using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WorkingWithAbstraction.Characters;

namespace WorkingWithAbstraction.Interfaces
{
   public interface IAttack
   {
       void Attack(Character target);
   }
}
