using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BlackJack
{
   public partial class Form1 : Form
   {
      List<Carte> paquet = new List<Carte>();
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         LoadImage();
         MixCards();
      }

      private void LoadImage()
      {
         try
         {
            //Création des objet cartes dans paquet
            String[] file = Directory.GetFiles(@"Image_Carte", "*.PNG");
            int valeur = 1;
            for (int i = 0; i < 52; ++i)
            {
               paquet.Add(new Carte(file[i]));
               if (valeur <= 9 && (i % 4) == 0)
               {
                  valeur++;
               }
               else if (valeur == 10 && (i % 16) == 0)
               {
                  valeur++;
               }
               paquet[i].SetValeur(valeur);
            }
            ////////////////////////////////////////
            string ccc = "ccc: ";
            for (int i = 0; i < 52; i++)
            {
               ccc += paquet[i].GetPath() + " #" + paquet[i].GetValeur().ToString() + "\n";
            }
            MessageBox.Show(ccc);
         }
         catch (Exception es)
         {
            if (es.HResult == -2147024893)// si le document image est présent ou pas
            {
               MessageBox.Show("Erreur:\nLe document d'image \"Image_Carte\" n'est plus dans repertoire courent ou a été modifier.");
            }
            else
            {
               MessageBox.Show(es.Message);
            }
            this.Close();
         }
      }

      private void MixCards()
      {
         List<Carte> Temp = new List<Carte>(paquet);
         Random rnd = new Random();
         int NbTemp;
         paquet.Clear();
         for (int i = 0; i < 52; i++)
         {
            do
            {
               NbTemp = rnd.Next(0, 52);
            } while (paquet.Contains(Temp[NbTemp]));
            paquet.Add(Temp[NbTemp]);
         }
      }

      private void RB_Humain1_and_RB_CPU1_CheckedChanged(object sender, EventArgs e)
      {
         if (RB_CPU1.Checked)
         {
            PN_AI_1.Enabled = true;
         }
         else
         {
            PN_AI_1.Enabled = false;
         }
      }

      private void RB_Humain2_and_RB_CPU2_CheckedChanged(object sender, EventArgs e)
      {
         if (RB_CPU2.Checked)
         {
            PN_AI_2.Enabled = true;
         }
         else
         {
            PN_AI_2.Enabled = false;
         }
      }
   }
}
