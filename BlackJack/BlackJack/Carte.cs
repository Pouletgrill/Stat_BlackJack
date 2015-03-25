using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Carte
    {
        Image cartePNG_ = null;
        String path_ = null;
        int valeur_;

        public Carte(String Path)
        {
            cartePNG_ = Image.FromFile(Path);
            path_ = Path;
        }

        public Image GetImage()
        {
            return cartePNG_;
        }

        public String GetPath()
        {
            return path_;
        }

        public int GetValeur()
        {
            return valeur_;
        }
    }
}
