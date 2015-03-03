using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGTest2
{
   public partial class Encounters : Form
   {
      private Character _character;
      private Creep _creep;
      private Fight _fight;
      private int _creeppredamage;
      private int _creeppostdamage;
      private int _creepdamage;
      private int _characterpredamage;
      private int _characterpostdamage;
      private int _characterdamage;
      public Encounters(ref Character character)
      {
         _character = character;
         InitializeComponent();
      }

      private void Encounters_Load(object sender, EventArgs e)
      {
         LblCharName.Text = _character.Name;
         LblCharLevel.Text = string.Format("{0}",_character.Level);
         LblCarExp.Text = string.Format("{0}-{1}", _character.CurrentExperience,
         _character.MaxExperience);
         LblCharHp.Text = string.Format("{0}-{1}", _character.CurrentHealthpoints, _character.Maxheathpoints);
         LblCharDamage.Text = string.Format("{0}-{1}", _character.MinDamage, _character.MaxDamage);
         BtnAttack.Hide();
         BtnFlee.Hide();
         BtnCombat.Hide();
         BtnCombatFlee.Hide();
         BtnFinish.Hide();

         LblCreepLevel.Hide();
         LblCreepDamage.Hide();
         LblCreepHealthpoints.Hide();
         lblCreepLvl.Hide();
         LblCreepDam.Hide();
         LblCreepHp.Hide();
         LblCreepNam.Hide();
         LblCreepName.Hide();
         btnRevive.Hide();

      }

      private void BtnCreateEncounter_Click(object sender, EventArgs e)
      {
         Random ran = new Random();
         Creep creep = new Creep("", 0, 0, 0, 0, 0, 0);

         int value = ran.Next(1, 4);

         switch (value)
         {
            case 1:
               creep.Level = 1;
               creep.ExperienceWorth = 300;
               creep.CurrentHealthpoints = 400;
               creep.Maxheathpoints = 400;
               creep.MinDamage = 20;
               creep.MaxDamage = 45;
               creep.Name = "SmallCreep";
               break;

            case 2:
               creep.Level = 2;
               creep.ExperienceWorth = 500;
               creep.CurrentHealthpoints = 500;
               creep.Maxheathpoints = 500;
               creep.MinDamage = 30;
               creep.MaxDamage = 60;
               creep.Name = "MediumCreep";
               break;

            case 3:
               creep.Level = 3;
               creep.ExperienceWorth = 800;
               creep.CurrentHealthpoints = 700;
               creep.Maxheathpoints = 700;
               creep.MinDamage = 50;
               creep.MaxDamage = 100;
               creep.Name = "BigCreep";
               break;
         }
         _creep = creep;
         BtnAttack.Show();
         BtnFlee.Show();

         RTBaction.Text = string.Format("Level {0} {1} was encountered.", creep.Level, creep.Name);


         LblCreepLevel.Text = _creep.Level.ToString();
         LblCreepDamage.Text = string.Format("{0}-{1}", _creep.MinDamage,
         _creep.MaxDamage);
         LblCreepHealthpoints.Text = string.Format("{0}-{1}", _creep.CurrentHealthpoints, _creep.Maxheathpoints);
         LblCreepName.Text = _creep.Name;

         LblCreepLevel.Show();
         LblCreepDamage.Show();
         LblCreepHealthpoints.Show();
         lblCreepLvl.Show();
         LblCreepDam.Show();
         LblCreepHp.Show();
         LblCreepNam.Show();
         LblCreepName.Show();

      }


      private void BtnGainExp_Click(object sender, EventArgs e)
      {
         Creep creepx = new Creep("bob", 1000, 100, 100, 0, 0, 1);

         Experience experience = new Experience(ref _character, ref creepx);
         experience.GainExp();

         LblCharName.Text = _character.Name;
         LblCharLevel.Text = _character.Level.ToString();
         LblCarExp.Text = string.Format("{0}-{1}", _character.CurrentExperience,
         _character.MaxExperience);
         LblCharHp.Text = string.Format("{0}-{1}", _character.CurrentHealthpoints, _character.Maxheathpoints);
         LblCharDamage.Text = string.Format("{0}-{1}", _character.MinDamage, _character.MaxDamage);
      }

      private void BtnAttack_Click(object sender, EventArgs e)
      {
         Fight fight = new Fight(ref _character, ref _creep);
         _fight = fight;

         RTBaction.Text = string.Format("{0} engaged {1}", _character.Name, _creep.Name);
         BtnCombat.Show();
         BtnCombatFlee.Show();
         BtnAttack.Hide();
         BtnFlee.Hide();
         BtnCreateEncounter.Hide();
      }

      private void BtnFlee_Click(object sender, EventArgs e)
      {
         RTBaction.Text = string.Format("{0} fled from the fight", _character.Name);
         BtnAttack.Hide();
         BtnCombat.Hide();
         BtnFlee.Hide();
         BtnCombatFlee.Hide();
         BtnCreateEncounter.Show();

         LblCreepLevel.Hide();
         LblCreepDamage.Hide();
         LblCreepHealthpoints.Hide();
         lblCreepLvl.Hide();
         LblCreepDam.Hide();
         LblCreepHp.Hide();
         LblCreepNam.Hide();
         LblCreepName.Hide();
      }

      private void BtnCombat_Click(object sender, EventArgs e)
      {
         if (RTBaction.Text == string.Format("{0} engaged {1}", _character.Name, _creep.Name))
         {
            RTBaction.Clear();
         }

         _characterpredamage = _creep.CurrentHealthpoints;
         _creeppredamage = _character.CurrentHealthpoints;

         _fight.Combat();

         _characterpostdamage = _creep.CurrentHealthpoints;
         _creeppostdamage = _character.CurrentHealthpoints;

         LblCharHp.Text = string.Format("{0}-{1}", _character.CurrentHealthpoints, _character.Maxheathpoints);
         LblCreepHealthpoints.Text = string.Format("{0}-{1}",_creep.CurrentHealthpoints, + _creep.Maxheathpoints);


         if (_creep.CurrentHealthpoints > 0 && _character.CurrentHealthpoints > 0)
         {
            if (_creep.Maxheathpoints == _creep.CurrentHealthpoints)
            {

               RTBaction.Text = string.Format("{0} did {1} in damage.{2}", _character.Name,
                  (_creep.Maxheathpoints - _creep.CurrentHealthpoints), Environment.NewLine);
               RTBaction.Text += string.Format("{0} did {1} in damage.{2}", _creep.Name, (_character.Maxheathpoints -
                                 _character.CurrentHealthpoints), Environment.NewLine);
            }
            else
            {
               _characterdamage = _characterpredamage - _characterpostdamage;
               _creepdamage = _creeppredamage - _creeppostdamage;

               RTBaction.Text = string.Format("{0} did {1} in damage.{2}", _character.Name, _characterdamage,
                  Environment.NewLine);
               RTBaction.Text += string.Format("{0} did {1} in damage", _creep.Name, _creepdamage);
            }
         }

         if (_creep.CurrentHealthpoints <= 0)
         {
            LblCreepHealthpoints.Text = string.Format("0-{0}", _creep.Maxheathpoints);
            RTBaction.Text = string.Format("{0} Won! {1} earned {2} in experience.", _character.Name, _character.Name, _creep.ExperienceWorth);

            Experience experience = new Experience(ref _character, ref _creep);
            experience.GainExp();

            LblCarExp.Text = string.Format("{0}-{1}", _character.CurrentExperience, _character.MaxExperience);
            LblCharLevel.Text = string.Format("{0}", _character.Level);
            LblCharHp.Text = string.Format("{0}-{1}", _character.CurrentHealthpoints, _character.Maxheathpoints);
            LblCharDamage.Text = string.Format("{0}-{1}", _character.MinDamage, _character.MaxDamage);

            BtnCombat.Hide();
            BtnCombatFlee.Hide();
            BtnFinish.Show();

         }
         if (_character.CurrentHealthpoints <= 0)
         {
            RTBaction.Text = string.Format("{0} died... Revive yourself to continue.", _character.Name);
            BtnCombat.Hide();
            BtnCombatFlee.Hide();
            BtnFinish.Show();
         }
      }

      private void BtnCombatFlee_Click(object sender, EventArgs e)
      {
         RTBaction.Text = string.Format("You fled from the fight");
         BtnAttack.Hide();
         BtnCombat.Hide();
         BtnFlee.Hide();
         BtnCombatFlee.Hide();
         BtnCreateEncounter.Show();

         LblCreepLevel.Hide();
         LblCreepDamage.Hide();
         LblCreepHealthpoints.Hide();
         lblCreepLvl.Hide();
         LblCreepDam.Hide();
         LblCreepHp.Hide();
         LblCreepNam.Hide();
         LblCreepName.Hide();
      }

      private void BtnFinish_Click(object sender, EventArgs e)
      {
         RTBaction.Clear();

         if (_character.CurrentHealthpoints > 0)
         {
            BtnCreateEncounter.Show();
         }
         BtnFinish.Hide();

         if (_character.CurrentHealthpoints <= 0)
         {
            btnRevive.Show();
         }

         LblCreepLevel.Hide();
         LblCreepDamage.Hide();
         LblCreepHealthpoints.Hide();
         lblCreepLvl.Hide();
         LblCreepDam.Hide();
         LblCreepHp.Hide();
         LblCreepNam.Hide();
         LblCreepName.Hide();
      }

      private void BtnPotion_Click(object sender, EventArgs e)
      {
         Heal heal = new Heal(ref _character);
         heal.Potion();

         LblCharHp.Text = string.Format("{0}-{1}", _character.CurrentHealthpoints, _character.Maxheathpoints);

         if (string.IsNullOrWhiteSpace(RTBaction.Text))
         {
            RTBaction.Text = string.Format("{0} healed up {1} in healthpoints.", _character.Name,
               heal.Smallpotion);
         }
         else
         {
            RTBaction.Text += string.Format("{0}{1} healed up {2} in healthpoints.", Environment.NewLine,
               _character.Name, heal.Smallpotion);
         }

         if (_character.CurrentHealthpoints > 0)
         {
            BtnCreateEncounter.Show();
         }
      }

      private void btnRevive_Click(object sender, EventArgs e)
      {
         _character.CurrentHealthpoints = _character.Maxheathpoints;

         LblCharHp.Text = string.Format("{0}-{1}", _character.CurrentHealthpoints, _character.Maxheathpoints);

         btnRevive.Hide();
         BtnCreateEncounter.Show();
      }
   }
}
