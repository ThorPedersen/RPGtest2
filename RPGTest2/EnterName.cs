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
   public partial class EnterName : Form
   {
      private string _name;
      private string _characterclass;
      private int Currentexp = 0;
      private int Maxexp = 1000;
      private int CurrentHp;
      private int MaxHp;
      private int Level = 1;
      private int MindDamage;
      private int MaxDamage;

      public EnterName()
      {
         InitializeComponent();
      }

      private void BtnName_Click(object sender, EventArgs e)
      {
         if (TxtName.Text != "" && CBClasses.SelectedItem != null)
         {

            _name = TxtName.Text;
            _characterclass =
            CBClasses.SelectedItem.ToString();

            if ((string)CBClasses.SelectedItem == "Warrior")
            {
               CurrentHp = 1500;
               MaxHp = 1500;
               MindDamage = 50;
               MaxDamage = 70;
            }
            if ((string)CBClasses.SelectedItem == "Ranger")
            {
               CurrentHp = 1100;
               MaxHp = 1100;
               MindDamage = 70;
               MaxDamage = 100;
            }
            if ((string)CBClasses.SelectedItem == "Wizard")
            {
               CurrentHp = 1300;
               MaxHp = 1300;
               MindDamage = 50;
               MaxDamage = 90;
            }

            Character character = new Character(_name, Currentexp, Maxexp, CurrentHp, MaxHp, MindDamage, MaxDamage, _characterclass, Level);
            Encounters encounters = new Encounters(ref character);
            encounters.Show();
            Hide();


         }
      }

      private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void EnterName_Load(object sender, EventArgs e)
      {
         TxtName.Text = "Thor";
         CBClasses.SelectedIndex = 1;
      }
   }
}
