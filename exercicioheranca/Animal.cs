using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio
{
   public class Animal
    {
       public float peso;
       public int idade, membros;    

       public virtual void locomover()
       {
           Console.WriteLine("Movendo-se");
       }
       public virtual void alimentar()
       {
           Console.WriteLine("Alimentando-se");
       }
       public virtual void emitirSom()
       {
           Console.WriteLine("Emitindo som");
       }
       public float getPeso()
       {
           return peso;
       }
       public void setPeso(float peso)
       {
           this.peso = peso;
       }
       public int getIdade()
       {
           return idade;
       }
       public void setIdade(int idade)
       {
           this.idade = idade;
       }
       public int getMembros()
       {
           return membros;
       }
       public void setMembros(int membros)
       {
           this.membros = membros;
       }
       public override string ToString()
       {
           return "Animal{"+"peso:"+peso+",idade:"+idade+",membros:"+membros+'}';
       }
   }
}
