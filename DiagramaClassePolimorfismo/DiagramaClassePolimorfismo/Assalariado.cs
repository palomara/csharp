using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramaClassePolimorfismo
{
    public class Assalariado : Empregado
    {
        private double salario;

        public double getSalario()
        {
            return salario;
        }
        public void setSalario(double salario)
        {
            this.salario = salario;
        }
        public override double Vencimento()
        {
            Console.Write("\n Assalariado \nnome: " + getNome() + "\nSobrenome: " + getSobrenome() + "\nSalario: " + salario + "\n\n");
            return salario;
        }
    }
}
