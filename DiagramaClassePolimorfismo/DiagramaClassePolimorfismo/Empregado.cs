﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramaClassePolimorfismo
{
   public class Empregado
    {
       public string nome, sobrenome, cpf;

       public virtual double Vencimento()
       { 
           return 1.20;
       }
       
       public string getNome(){
         return nome;
       }

       public void setNome (string nome) {
        this.nome = nome;
       }

       public string getSobrenome() {
        return sobrenome;
       }
       
       public void setSobrenome (string sobrenome) {
        this.sobrenome = sobrenome;
       }
       public string getCpf () {
           return cpf;
       }
        public void setCpf (string cpf) {
         this.cpf = cpf;
        }

        public override string ToString()
        {
            return "Empregado:{"+"\nnome :"+nome+"\nsobrenome: "+sobrenome+"\ncpf: "+cpf+'}';
        }
   }
}
