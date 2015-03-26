using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Joueur
    {
        int TotalPoint;
        String Nom_;
        int Cpu_Level_;
        bool Joue_ = true;


        public Joueur(String Nom)
        {
            TotalPoint = 0;
            Nom_ = Nom;
            Cpu_Level_ = 0;
        }
        public Joueur(int Cpu_Level, String Nom)
        {
            TotalPoint = 0;
            Nom_ = Nom;
            Cpu_Level_ = Cpu_Level;
        }

        public int GetTotal()
        {
            return TotalPoint;
        }
        public string GetNom()
        {
            return Nom_;
        }
        public int GetCpuLevel()
        {
            return Cpu_Level_;
        }
        public void SetTotal(int Total)
        {
            TotalPoint = Total;
        }
        public void ArreteDeJouer()
        {
            Joue_ = false;
        }
        public bool JoueEncore()
        {
            return Joue_;
        }
    }
}
