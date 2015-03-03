using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTest2
{
   public class Heal
   {
      private readonly Character _character;
      private int _excessHp;
      private int _smallpotion = 100;

      public Heal(ref Character character)
      {
         _character = character;
      }

      public int Smallpotion
      {
         get { return _smallpotion; }
         set { _smallpotion = value; }
      }

      public void Potion()
      {
         _excessHp = _character.CurrentHealthpoints += _smallpotion;
         if (_excessHp > _character.Maxheathpoints)
            _character.CurrentHealthpoints = _character.Maxheathpoints;
      }
   }
}
