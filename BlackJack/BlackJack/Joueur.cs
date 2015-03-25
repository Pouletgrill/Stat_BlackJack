﻿using System;
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



      public Joueur(String Nom)
      {
         TotalPoint = 0;
         Nom_ = Nom;
         Cpu_Level_ = 0;
      }
      public Joueur(int Cpu_Level,String Nom)
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


   }
}
