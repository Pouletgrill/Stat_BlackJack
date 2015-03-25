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
   public partial class Jeu : Form
   {
      List<Carte> paquet = new List<Carte>();
      Point CarteJ1 = new Point(200, 800);
      Point CarteJ2 = new Point(600, 800);


      public Jeu()
      {
         InitializeComponent();
      }
      public Jeu(int CPU_Level)
      {
         InitializeComponent();
      }
      public Jeu(int CPU_Level1, int CPU_Level2)
      {
         InitializeComponent();

      }
      private void Jeu_Load(object sender, EventArgs e)
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
               if (valeur <= 9 && (i % 4) == 0)
               {
                  valeur++;
               }
               else if (valeur == 10 && (i % 16) == 0)
               {
                  valeur++;
               }
               paquet.Add(new Carte(file[i], valeur));
            }
            ////////////////////////////////////////
            string ccc = "";
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

      private void AfficherCarte(int posPaquet,Joueur joueur)
      {            

            PictureBox PBox = new PictureBox();
            PBox.BackgroundImage = paquet[posPaquet].GetImage();
            PBox.Height = PBox.Width = 47;
            

            if(joueur.GetNom() == "J1")
               PBox.Location = CarteJ1;

            paquet[posPaquet].GetValeur();
            this.Controls.Add(PBox);
      }

      private void BTN_Commencer_Click(object sender, EventArgs e)
      {
       
            
               
      }
   }
}
