﻿using System;
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
            //si le total est trop bas
            if (GetTotal() > 10)
            {
                if (Compte_carte_)//Avec comptage de cartes
                {
                    for (int i = IndexCarte; i < paquet.Count(); i++)
                    {
                        //Calcule stat
                    }
                }
                else //Sans comptage de cartes
                {
                    for (int i = IndexCarte; i < paquet.Count(); i++)
                    {
                        //Calcule stat
                    }
                }

                //On vérifie si on continue ou pas
                if (GetCpuLevel() == 1 && Stats <= 50)//Courageux
                {
                    ArreteDeJouer();
                }
                else if (GetCpuLevel() == 2 && Stats <= 65)//Moyen
                {
                    ArreteDeJouer();
                }
                else if (GetCpuLevel() == 3 && Stats <= 80)//Prudent
                {
                    ArreteDeJouer();
                }
            }
            return Stats;
        }
    }
}
