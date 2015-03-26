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
      Point CarteJ1 = new Point(12, 100);
      Point CarteJ2 = new Point(500, 100);
      Joueur J1 ;
      Joueur J2;
      int CompteurCarte = 0;
	   
	  const int CarteHeight = 127;
	  const int CarteWidth = 88;
	  const int BigValueAs = 11;
	  const int SmallValueAs = 1;
	  const int LimitBlackjack = 21;

      public Jeu()
      {
         InitializeComponent();
         J1 = new Joueur("J1");
         J2 = new Joueur("J2");
      }
      public Jeu(int CPU_Level, bool Compter)
      {
         InitializeComponent();
         J1 = new Joueur(CPU_Level,"J1");
         J2 = new Joueur("J2");
      }
      public Jeu(int CPU_Level1, bool Compter1, int CPU_Level2, bool Compter2)
      {
         InitializeComponent();
         J1 = new Joueur(CPU_Level1,"J1");
         J2 = new Joueur(CPU_Level2,"J2");

      }
      private void Jeu_Load(object sender, EventArgs e)
      {
         LoadImage();
         MixCards();
         BTN_Continuer_J1.Enabled = false;
         BTN_Arreter_J1.Enabled = false;
         BTN_Continuer_J2.Enabled = false;
         BTN_Arreter_J2.Enabled = false;
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

	  

      private void AfficherUneCarte(int posPaquet,Joueur joueur)
      {
     	  if(posPaquet < 52 && posPaquet >=0)
		  {
			PictureBox PBox = new PictureBox();
			PBox.BackgroundImage = paquet[posPaquet].GetImage();
			PBox.Height = CarteHeight; 
			PBox.Width = CarteWidth;

			PBox.BackgroundImageLayout = ImageLayout.Stretch;
			if (joueur.GetNom() == "J1")
			{
			   PBox.Location = CarteJ1;
			   CarteJ1.X += 18;
			   CarteJ1.Y -= 2;
			}               
			else
			{
			   PBox.Location = CarteJ2;
			   CarteJ2.X += 18;
			   CarteJ2.Y -= 2;
			}

			if (joueur.GetTotal() + paquet[posPaquet].GetValeur() > LimitBlackjack && paquet[posPaquet].GetValeur() == BigValueAs)
			{
			   paquet[posPaquet].SetValeur(SmallValueAs);
			}            
			joueur.SetTotal(joueur.GetTotal() + paquet[posPaquet].GetValeur());

			this.Controls.Add(PBox);
			PBox.BringToFront(); 
          }
		  else
		  {
			MessageBox.Show("Possition dans le paquet de carte invalide");  
		  
		  }
		  LB_Total_J1.Text = J1.GetTotal().ToString();
	      LB_Total_J2.Text = J2.GetTotal().ToString();
      }	     
	  
	
      private void BTN_Commencer_Click(object sender, EventArgs e)
      {
         while(CompteurCarte<4)
         {
            if (CompteurCarte % 2 == 0)
               AfficherUneCarte(CompteurCarte, J1);
            else
               AfficherUneCarte(CompteurCarte, J2);
            CompteurCarte++;
         }      

         BTN_Continuer_J1.Enabled = true;
         BTN_Arreter_J1.Enabled = true;	 
         BTN_Commencer.Enabled = false;
         BTN_Commencer.Visible = false;
      }


      private void BTN_Continuer_J1_Click(object sender, EventArgs e)
      {
         AfficherUneCarte(CompteurCarte, J1);
         CompteurCarte++;

         BTN_Continuer_J1.Enabled = false;
         BTN_Arreter_J1.Enabled = false;
         BTN_Continuer_J2.Enabled = true;
         BTN_Arreter_J2.Enabled = true;

      }

      private void BTN_Continuer_J2_Click(object sender, EventArgs e)
      {
         AfficherUneCarte(CompteurCarte, J2);
         CompteurCarte++;

         BTN_Continuer_J1.Enabled = true;
         BTN_Arreter_J1.Enabled = true;
         BTN_Continuer_J2.Enabled = false;
         BTN_Arreter_J2.Enabled = false;
      }
   }
}
