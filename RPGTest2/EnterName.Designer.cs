namespace RPGTest2
{
   partial class EnterName
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.BtnName = new System.Windows.Forms.Button();
         this.TxtName = new System.Windows.Forms.TextBox();
         this.CBClasses = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // BtnName
         // 
         this.BtnName.Location = new System.Drawing.Point(517, 195);
         this.BtnName.Name = "BtnName";
         this.BtnName.Size = new System.Drawing.Size(75, 23);
         this.BtnName.TabIndex = 0;
         this.BtnName.Text = "Submit";
         this.BtnName.UseVisualStyleBackColor = true;
         this.BtnName.Click += new System.EventHandler(this.BtnName_Click);
         // 
         // TxtName
         // 
         this.TxtName.Location = new System.Drawing.Point(517, 142);
         this.TxtName.Name = "TxtName";
         this.TxtName.Size = new System.Drawing.Size(100, 20);
         this.TxtName.TabIndex = 1;
         // 
         // CBClasses
         // 
         this.CBClasses.FormattingEnabled = true;
         this.CBClasses.Items.AddRange(new object[] {
            "Warrior",
            "Ranger",
            "Wizard"});
         this.CBClasses.Location = new System.Drawing.Point(517, 168);
         this.CBClasses.Name = "CBClasses";
         this.CBClasses.Size = new System.Drawing.Size(121, 21);
         this.CBClasses.TabIndex = 2;
         this.CBClasses.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(418, 145);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(81, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Choose a name";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(418, 171);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(79, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "Choose a class";
         // 
         // EnterName
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1184, 562);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.CBClasses);
         this.Controls.Add(this.TxtName);
         this.Controls.Add(this.BtnName);
         this.Name = "EnterName";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.EnterName_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button BtnName;
      private System.Windows.Forms.TextBox TxtName;
      private System.Windows.Forms.ComboBox CBClasses;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
   }
}

