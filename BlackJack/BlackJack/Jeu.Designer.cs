namespace BlackJack
{
   partial class Jeu
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jeu));
         this.BTN_Continuer_J1 = new System.Windows.Forms.Button();
         this.BTN_Arreter_J1 = new System.Windows.Forms.Button();
         this.BTN_Continuer_J2 = new System.Windows.Forms.Button();
         this.BTN_Arreter_J2 = new System.Windows.Forms.Button();
         this.BTN_Commencer = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // BTN_Continuer_J1
         // 
         this.BTN_Continuer_J1.Location = new System.Drawing.Point(75, 516);
         this.BTN_Continuer_J1.Name = "BTN_Continuer_J1";
         this.BTN_Continuer_J1.Size = new System.Drawing.Size(103, 44);
         this.BTN_Continuer_J1.TabIndex = 0;
         this.BTN_Continuer_J1.Text = "Continuer";
         this.BTN_Continuer_J1.UseVisualStyleBackColor = true;
         // 
         // BTN_Arreter_J1
         // 
         this.BTN_Arreter_J1.Location = new System.Drawing.Point(184, 516);
         this.BTN_Arreter_J1.Name = "BTN_Arreter_J1";
         this.BTN_Arreter_J1.Size = new System.Drawing.Size(104, 44);
         this.BTN_Arreter_J1.TabIndex = 1;
         this.BTN_Arreter_J1.Text = "Arrêter";
         this.BTN_Arreter_J1.UseVisualStyleBackColor = true;
         // 
         // BTN_Continuer_J2
         // 
         this.BTN_Continuer_J2.Location = new System.Drawing.Point(484, 517);
         this.BTN_Continuer_J2.Name = "BTN_Continuer_J2";
         this.BTN_Continuer_J2.Size = new System.Drawing.Size(104, 44);
         this.BTN_Continuer_J2.TabIndex = 2;
         this.BTN_Continuer_J2.Text = "Continuer";
         this.BTN_Continuer_J2.UseVisualStyleBackColor = true;
         // 
         // BTN_Arreter_J2
         // 
         this.BTN_Arreter_J2.Location = new System.Drawing.Point(594, 517);
         this.BTN_Arreter_J2.Name = "BTN_Arreter_J2";
         this.BTN_Arreter_J2.Size = new System.Drawing.Size(108, 44);
         this.BTN_Arreter_J2.TabIndex = 3;
         this.BTN_Arreter_J2.Text = "Arrêter";
         this.BTN_Arreter_J2.UseVisualStyleBackColor = true;
         // 
         // BTN_Commencer
         // 
         this.BTN_Commencer.Location = new System.Drawing.Point(302, 12);
         this.BTN_Commencer.Name = "BTN_Commencer";
         this.BTN_Commencer.Size = new System.Drawing.Size(164, 70);
         this.BTN_Commencer.TabIndex = 4;
         this.BTN_Commencer.Text = "Commencer";
         this.BTN_Commencer.UseVisualStyleBackColor = true;
         this.BTN_Commencer.Click += new System.EventHandler(this.BTN_Commencer_Click);
         // 
         // Jeu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::BlackJack.Properties.Resources.images;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(751, 606);
         this.Controls.Add(this.BTN_Commencer);
         this.Controls.Add(this.BTN_Arreter_J2);
         this.Controls.Add(this.BTN_Continuer_J2);
         this.Controls.Add(this.BTN_Arreter_J1);
         this.Controls.Add(this.BTN_Continuer_J1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "Jeu";
         this.Text = "BlackJack !";
         this.Load += new System.EventHandler(this.Jeu_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button BTN_Continuer_J1;
      private System.Windows.Forms.Button BTN_Arreter_J1;
      private System.Windows.Forms.Button BTN_Continuer_J2;
      private System.Windows.Forms.Button BTN_Arreter_J2;
      private System.Windows.Forms.Button BTN_Commencer;
   }
}