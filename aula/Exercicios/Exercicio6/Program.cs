using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        { /* Escreva um programa que leia um valor em Reais(R$), leia também a cotação do Dólar,
           realize o cáculo da conversão de moedas (de reais para doláres) e exiba na tela*/
            //Paloma Rangel ETEC ZL Noite Info 2 B DS Wagner França

            float real, dolar, con;

            Console.WriteLine("*Conversor de Moedas*\n");
            Console.WriteLine("Digite o valor em Reais(R$): ");
            real = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cotação do Dolár: ");
            dolar = float.Parse(Console.ReadLine());

            con = dolar * real;

            Console.WriteLine("A conversão de {0}R$ em cotação de {1}$ para dólares é: {2}", real, dolar, con);

            Console.ReadKey();
        }
    }
}
