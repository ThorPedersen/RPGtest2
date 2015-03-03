using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTest2
{
   public class Character
   {
      private string _name;
      private int _currentExperience;
      private int _maxExperience;
      private int _currentHealthpoints;
      private int _maxheathpoints;
      private int _minDamage;
      private int _maxDamage;
      private int _level;
      private string _charclass;

      public Character(string name, int currentexp, int maxexp, int currenthp, int maxhp, int mindamage, int maxdamage, string charclass, int level)
      {
         _name = name;
         _currentExperience = currentexp;
         _maxExperience = maxexp;
         _currentHealthpoints = currenthp;
         _maxheathpoints = maxhp;
         _minDamage = mindamage;
         _maxDamage = maxdamage;
         _charclass = charclass;
         _level = level;
      }

      public string Name
      {
         get { return _name; }
         set { _name = value; }
      }

      public int CurrentExperience
      {
         get { return _currentExperience; }
         set { _currentExperience = value; }
      }

      public int MaxExperience
      {
         get { return _maxExperience; }
         set { _maxExperience = value; }
      }

      public int CurrentHealthpoints
      {
         get { return _currentHealthpoints; }
         set { _currentHealthpoints = value; }
      }

      public int Maxheathpoints
      {
         get { return _maxheathpoints; }
         set { _maxheathpoints = value; }
      }

      public int MinDamage
      {
         get { return _minDamage; }
         set { _minDamage = value; }
      }

      public int MaxDamage
      {
         get { return _maxDamage; }
         set { _maxDamage = value; }
      }

      public int Level
      {
         get { return _level; }
         set { _level = value; }
      }

      public string Charclass
      {
         get { return _charclass; }
         set { _charclass = value; }
      }
   }
}
