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
        Point CarteJ1 = new Point(15, 100);
        Point CarteJ2 = new Point(523, 100);
        Joueur J1;
        Joueur J2;
        int A_Qui_Le_Tour = 1;
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
            J1 = new Joueur(CPU_Level, Compter, "J1");
            J2 = new Joueur("J2");
        }
        public Jeu(int CPU_Level1, bool Compter1, int CPU_Level2, bool Compter2)
        {
            InitializeComponent();
            J1 = new Joueur(CPU_Level1, Compter1, "J1");
            J2 = new Joueur(CPU_Level2, Compter2, "J2");

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

        private void AfficherUneCarte(int posPaquet, Joueur joueur)
        {
            if (posPaquet < 52 && posPaquet >= 0)
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
            while (CompteurCarte < 4)
            {
                if (A_Qui_Le_Tour == 1)
                {
                    AfficherUneCarte(CompteurCarte, J1);
                    A_Qui_Le_Tour = 2;
                }
                else
                {
                    AfficherUneCarte(CompteurCarte, J2);
                    A_Qui_Le_Tour = 1;
                }
                CompteurCarte++;
            }

            BTN_Continuer_J1.Enabled = true;
            BTN_Arreter_J1.Enabled = true;
            BTN_Commencer.Enabled = false;
            BTN_Commencer.Visible = false;
        }

        private void BTN_Continuer_J1_Click(object sender, EventArgs e)
        {
            LB_J1_Stats.Text = J1.CalculerStat(paquet, CompteurCarte).ToString() + "%";
            if (J1.JoueEncore())
            {
                Jouer(1);
            }
        }

        private void BTN_Continuer_J2_Click(object sender, EventArgs e)
        {
            LB_J2_Stats.Text = J2.CalculerStat(paquet, CompteurCarte).ToString() + "%";
            if (J2.JoueEncore())
            {
                Jouer(2);
            }
        }

        private void Jouer(int QuiJoue)
        {
            if (QuiJoue == 1)
            {
                AfficherUneCarte(CompteurCarte, J1);
                CompteurCarte++;

                if (J2.JoueEncore())
                {
                    BTN_Continuer_J1.Enabled = false;
                    BTN_Arreter_J1.Enabled = false;
                    BTN_Continuer_J2.Enabled = true;
                    BTN_Arreter_J2.Enabled = true;
                }
            }
            else
            {
                AfficherUneCarte(CompteurCarte, J2);
                CompteurCarte++;

                if (J1.JoueEncore())
                {
                    BTN_Continuer_J1.Enabled = true;
                    BTN_Arreter_J1.Enabled = true;
                    BTN_Continuer_J2.Enabled = false;
                    BTN_Arreter_J2.Enabled = false;
                }
            }
            if (J2.GetTotal() > 21)
            {
                J2.ArreteDeJouer();
                LB_J2_Depasse.Visible = true;
                LB_J2_Depasse.BringToFront();
                BTN_Continuer_J2.Enabled = false;
                BTN_Arreter_J2.Enabled = false;
            }
            if (J1.GetTotal() > 21)
            {
                J1.ArreteDeJouer();
                LB_J1_Depasse.Visible = true;
                LB_J1_Depasse.BringToFront();
                BTN_Continuer_J1.Enabled = false;
                BTN_Arreter_J1.Enabled = false;
            }
        }

        private void BTN_Arreter_J1_Click(object sender, EventArgs e)
        {
            J1.ArreteDeJouer();

            if (J2.JoueEncore())
            {
                BTN_Continuer_J1.Enabled = false;
                BTN_Arreter_J1.Enabled = false;
                BTN_Continuer_J2.Enabled = true;
                BTN_Arreter_J2.Enabled = true;
            }
            else
            {
                FinDeLaPartie();
            }
        }

        private void BTN_Arreter_J2_Click(object sender, EventArgs e)
        {
            J2.ArreteDeJouer();

            if (J1.JoueEncore())
            {
                BTN_Continuer_J1.Enabled = true;
                BTN_Arreter_J1.Enabled = true;
                BTN_Continuer_J2.Enabled = false;
                BTN_Arreter_J2.Enabled = false;
            }
            else
            {
                FinDeLaPartie();
            }
        }

        private void FinDeLaPartie()
        {
            MessageBox.Show("fin de la partie");
            BTN_Continuer_J1.Enabled = false;
            BTN_Arreter_J1.Enabled = false;
            BTN_Continuer_J2.Enabled = false;
            BTN_Arreter_J2.Enabled = false;
        }

        private void BTN_Quit_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Voulez-vous vraiment quitter le Jeu ?",
            "Fermeture du jeu..",
            MessageBoxButtons.YesNo);
            if (result1 == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
