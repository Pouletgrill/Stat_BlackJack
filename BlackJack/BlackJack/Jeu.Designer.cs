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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.LB_Total_J1 = new System.Windows.Forms.Label();
         this.LB_Total_J2 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // BTN_Continuer_J1
         // 
         this.BTN_Continuer_J1.Location = new System.Drawing.Point(50, 252);
         this.BTN_Continuer_J1.Name = "BTN_Continuer_J1";
         this.BTN_Continuer_J1.Size = new System.Drawing.Size(103, 31);
         this.BTN_Continuer_J1.TabIndex = 0;
         this.BTN_Continuer_J1.Text = "Continuer";
         this.BTN_Continuer_J1.UseVisualStyleBackColor = true;
         this.BTN_Continuer_J1.Click += new System.EventHandler(this.BTN_Continuer_J1_Click);
         // 
         // BTN_Arreter_J1
         // 
         this.BTN_Arreter_J1.Location = new System.Drawing.Point(159, 252);
         this.BTN_Arreter_J1.Name = "BTN_Arreter_J1";
         this.BTN_Arreter_J1.Size = new System.Drawing.Size(107, 31);
         this.BTN_Arreter_J1.TabIndex = 1;
         this.BTN_Arreter_J1.Text = "Arrêter";
         this.BTN_Arreter_J1.UseVisualStyleBackColor = true;
         // 
         // BTN_Continuer_J2
         // 
         this.BTN_Continuer_J2.Location = new System.Drawing.Point(464, 252);
         this.BTN_Continuer_J2.Name = "BTN_Continuer_J2";
         this.BTN_Continuer_J2.Size = new System.Drawing.Size(99, 32);
         this.BTN_Continuer_J2.TabIndex = 2;
         this.BTN_Continuer_J2.Text = "Continuer";
         this.BTN_Continuer_J2.UseVisualStyleBackColor = true;
         // 
         // BTN_Arreter_J2
         // 
         this.BTN_Arreter_J2.Location = new System.Drawing.Point(569, 252);
         this.BTN_Arreter_J2.Name = "BTN_Arreter_J2";
         this.BTN_Arreter_J2.Size = new System.Drawing.Size(104, 32);
         this.BTN_Arreter_J2.TabIndex = 3;
         this.BTN_Arreter_J2.Text = "Arrêter";
         this.BTN_Arreter_J2.UseVisualStyleBackColor = true;
         // 
         // BTN_Commencer
         // 
         this.BTN_Commencer.Location = new System.Drawing.Point(302, 30);
         this.BTN_Commencer.Name = "BTN_Commencer";
         this.BTN_Commencer.Size = new System.Drawing.Size(164, 70);
         this.BTN_Commencer.TabIndex = 4;
         this.BTN_Commencer.Text = "Commencer";
         this.BTN_Commencer.UseVisualStyleBackColor = true;
         this.BTN_Commencer.Click += new System.EventHandler(this.BTN_Commencer_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 30);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(81, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "Total Joueur 1 :";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(592, 30);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(81, 13);
         this.label2.TabIndex = 6;
         this.label2.Text = "Total Joueur 2 :";
         // 
         // LB_Total_J1
         // 
         this.LB_Total_J1.AutoSize = true;
         this.LB_Total_J1.Location = new System.Drawing.Point(100, 29);
         this.LB_Total_J1.Name = "LB_Total_J1";
         this.LB_Total_J1.Size = new System.Drawing.Size(13, 13);
         this.LB_Total_J1.TabIndex = 7;
         this.LB_Total_J1.Text = "0";
         // 
         // LB_Total_J2
         // 
         this.LB_Total_J2.AutoSize = true;
         this.LB_Total_J2.Location = new System.Drawing.Point(679, 29);
         this.LB_Total_J2.Name = "LB_Total_J2";
         this.LB_Total_J2.Size = new System.Drawing.Size(13, 13);
         this.LB_Total_J2.TabIndex = 8;
         this.LB_Total_J2.Text = "0";
         // 
         // Jeu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::BlackJack.Properties.Resources.images;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(751, 289);
         this.Controls.Add(this.LB_Total_J2);
         this.Controls.Add(this.LB_Total_J1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
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
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button BTN_Continuer_J1;
      private System.Windows.Forms.Button BTN_Arreter_J1;
      private System.Windows.Forms.Button BTN_Continuer_J2;
      private System.Windows.Forms.Button BTN_Arreter_J2;
      private System.Windows.Forms.Button BTN_Commencer;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label LB_Total_J1;
      private System.Windows.Forms.Label LB_Total_J2;
   }
}