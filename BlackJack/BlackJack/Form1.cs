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
            MixCards(paquet);
        }

        private void LoadImage()
        {
            try
            {
                String[] array = Directory.GetFiles(@"Image_Carte", "*.PNG");
                for (int i = 0; i < 54; ++i)
                {
                    paquet.Add(new Carte(array[i]));
                }
                MessageBox.Show(paquet.Count().ToString());
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message.ToString());
            }
        }

        private void MixCards()
        {
            List<Carte> Temp = new List<Carte>(paquet);
            Random rnd = new Random();
            int NbTemp;
            paquet.Clear();
            for (int i = 0; i < 54; i++)
            {
                do
                {
                    NbTemp = rnd.Next(0, 54);
                } while (paquet.Contains(Temp[NbTemp]));
                paquet.Add(Temp[NbTemp]);
            }
        }
    }
}
