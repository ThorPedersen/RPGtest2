using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGTest2
{
   public class Fight
   {
      private readonly Character _character;
      private readonly Creep _creep;
      private int _characterdamage;
      private int _creepDamage;

      public Fight(ref Character character, ref Creep creep)
      {
         _character = character;
         _creep = creep;
      }

      public void Combat()
      {
         Random ran = new Random();

         _characterdamage = ran.Next(_character.MinDamage, _character.MaxDamage);

         _creep.CurrentHealthpoints -= _characterdamage;

         _creepDamage = ran.Next(_creep.MinDamage, _creep.MaxDamage);

         _character.CurrentHealthpoints -= _creepDamage;
      }

   }
}
