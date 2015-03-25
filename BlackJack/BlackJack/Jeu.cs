using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
   public partial class Jeu : Form
   {
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
   }
}
