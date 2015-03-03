using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTest2
{
   public class Experience
   {
      private readonly Character _character;
      private readonly Creep _creep;
      private int _expworth;
      private int _excessExp;
      public Experience(ref Character character, ref Creep creep)
      {
         _character = character;
         _creep = creep;
      }

      public void GainExp()
      {
        _expworth = _character.CurrentExperience += _creep.ExperienceWorth;

         if (_expworth >= _character.MaxExperience)
         {
            _excessExp = _expworth - _character.MaxExperience;
            GainLevel(_excessExp);
         }
  
      }

      public void GainLevel(int excessExp)
      {
         _character.Level += 1;
         _character.CurrentExperience = excessExp;
         _character.MaxExperience += 500;
         _character.Maxheathpoints += 100;
         _character.CurrentHealthpoints = _character.Maxheathpoints;
         _character.MinDamage += 20;
         _character.MaxDamage += 30;

      }

   }
}
