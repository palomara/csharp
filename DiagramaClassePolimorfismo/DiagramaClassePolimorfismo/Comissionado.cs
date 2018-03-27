using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramaClassePolimorfismo
{
    public class Comissionado : Empregado
    {
        private double totalVenda, taxaComissao;

        //public void vencimento(double vencimento) { }
        public double getTotalVenda () {
         return totalVenda;
        }
        public void setTotalVenda(double totalVenda) {
        this.totalVenda = totalVenda;
        }
        public double getTaxaComissao() {
         return taxaComissao;
        }
        public void setTaxaComissao (double taxaComissao) {
        this.taxaComissao = taxaComissao;
        }

        public override double Vencimento()
        {    double venc;
             venc = totalVenda * (taxaComissao / 100);
             Console.Write("\n\nComissionado"+"\nnome :" + getNome() + "\nsobrenome: " + getSobrenome() + "\nsalario:"+venc + "\n");   
             return venc;
        }

    }
}
