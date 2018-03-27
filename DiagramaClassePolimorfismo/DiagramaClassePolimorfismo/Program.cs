using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramaClassePolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado empregado1 = new Empregado();
            Assalariado assalariado1 = new Assalariado();
            Comissionado comissionado1 = new Comissionado();
            Horista horista1 = new Horista();

            empregado1.setNome("Zé");
            empregado1.setSobrenome("Guedes");
            empregado1.setCpf("46564401833");
            assalariado1.setNome("Manoel");
            assalariado1.setSobrenome("Brito");
            assalariado1.setCpf("7896540244");
            assalariado1.setSalario(1200.20);
            comissionado1.setNome("Huguinho");
            comissionado1.setSobrenome("da Rocha");
            comissionado1.setCpf("9856210411");
            comissionado1.setTaxaComissao(12);
            comissionado1.setTotalVenda(1100);
            horista1.setNome("Xaiane");
            horista1.setSobrenome("Silva");
            horista1.setCpf("2301478566");
            horista1.setHorasTrabalhadas(44);
            horista1.setPrecoHora(34.00);

            Console.WriteLine(empregado1.ToString());
            Console.WriteLine(assalariado1.ToString());
            Console.WriteLine(comissionado1.ToString());
            Console.WriteLine(horista1.ToString());

            empregado1.Vencimento();
            assalariado1.Vencimento();
            comissionado1.Vencimento();
            horista1.Vencimento();


            Console.ReadKey();
         
        }
    }
}
