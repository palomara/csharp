using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {//início Main

            //declaração de variáveis
            int a, b, total;

            //atribuição de valores
            a = 20;
            b = 10;

            /* concatenação de valores a serem exibidos na tela 
             Cálculo da operação sendo realizado entre parênteses*/

            Console.WriteLine(a + "+" + b + "=" + (a + b));

            //Resultado do cálculo da operação sendo atribuído em uma variável
            total = a - b;

            Console.WriteLine(a + "-" + b + "=" + total);
            Console.WriteLine(a + "*" + b + "=" + (a * b));
            Console.WriteLine(a + "/" + b + "=" + (a / b));
            Console.WriteLine(a + "%" + b + "=" + (a % b));

            Console.ReadKey(); //instrução utilizada para dar uma pausa na vizualização 




        }
    }
}
