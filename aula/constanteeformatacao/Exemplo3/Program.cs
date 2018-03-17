using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {//definição de constante PI

            const double pi = 3.14159265358979323846264338327950;

            //declaração de variável e atribuição de valor na variável

            double raio = 10;
            double area;

            Console.WriteLine("Cálculo da área de um círculo \n");
            Console.WriteLine("Fórmula: área * pi * raio * raio \n");

            //Math.Pow: exponenciação 
            area = pi * Math.Pow(raio, 2); //sem usar o método Pow seria: area = pi * raio * raio

            Console.WriteLine("Área={0}", area); //exibe resultado sem formatação de casas decimais
            Console.WriteLine("Área={0:N}", area); //exibe resultado com formatação de duas casas decimais
            Console.WriteLine("Área={0:N5}", area); //exibe resultado com formatação de cinco casas decimais

            Console.ReadKey();
        }
    }
}
