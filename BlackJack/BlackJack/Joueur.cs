using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Joueur
    {
        int TotalPoint = 0;
        String Nom_;
        int Cpu_Level_ = -1;
        bool Joue_ = true;
        bool Compte_carte_ = false;

        public Joueur(String Nom)
        {
            Nom_ = Nom;
        }
        public Joueur(int Cpu_Level, bool CompteCarte, String Nom)
        {
            Nom_ = Nom;
            Cpu_Level_ = Cpu_Level;
            Compte_carte_ = CompteCarte;
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

        //si les conditions ne sont plus favorable, le joueur s'arrête de lui même
        public int CalculerStat(List<Carte> paquet, int IndexCarte)
        {
            int Stats = 0;//    %
            if (GetCpuLevel() > 0 && GetTotal() > 10)//si le total est trop bas ou le joueur n'est pas un CPU
            {
                if (Compte_carte_)//Avec comptage de cartes
                {
                    for (int i = IndexCarte; i < paquet.Count(); i++)
                    {

                    }
                }
                else //Sans comptage de cartes
                {
                    for (int i = IndexCarte; i < paquet.Count(); i++)
                    {

                    }
                }
                if (GetCpuLevel() == 1)
                {

                }
                else if (GetCpuLevel() == 2)
                {

                }
                else if (GetCpuLevel() == 3)
                {

                }
            }
            else //ne retourne que les stats
            {

            }
            return Stats;
        }
    }
}
