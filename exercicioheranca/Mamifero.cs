﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio
{
   public class Mamifero : Animal
    {
       private string corPelo, raca;

       public string getCorPelo()
       {
           return corPelo;
       }
       public void setCorPelo(string corPelo)
       {
           this.corPelo = corPelo;
       }
       public string getRaca()
       {
           return raca;
       }
       public void setRaca(string raca)
       {
           this.raca = raca;
       }
       public override string ToString()
       {
           return "Mamifero{" + "cor do pelo:" + corPelo + ",raça:" + raca + '}';
       }

    }
}
