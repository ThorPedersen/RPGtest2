using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTest2
{
   public class Creep
   {
      private string _name;
      private int _experienceWorth;
      private int _currentHealthpoints;
      private int _maxheathpoints;
      private int _minDamage;
      private int _maxDamage;
      private int _level;

      public Creep(string name, int expworth, int currenthp, int maxhp, int mindamage, int maxdamage, int level)
      {
         _name = name;
         _experienceWorth = expworth;
         _currentHealthpoints = currenthp;
         _maxheathpoints = maxhp;
         _minDamage = mindamage;
         _maxDamage = maxdamage;
         _level = level;
      }

      public string Name
      {
         get { return _name; }
         set { _name = value; }
      }

      public int ExperienceWorth
      {
         get { return _experienceWorth; }
         set { _experienceWorth = value; }
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
   }
}
