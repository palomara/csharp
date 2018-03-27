using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Mamifero gato = new Mamifero();
            Reptil cobra = new Reptil();
            Ave papagaio = new Ave();
            Canguru canguru = new Canguru();
            Cachorro cao = new Cachorro();
            Tartaruga tartaruga = new Tartaruga();
            Tucano tucano = new Tucano();

            gato.setCorPelo("Marrom");
            gato.setIdade(7);
            gato.setMembros(3);
            gato.setPeso(6.05f);
            gato.setRaca("Siamês");

            cobra.setCorEscama("Verde");
            cobra.setIdade(9);
            cobra.setPeso(4.3f);
            cobra.setMembros(8);

            papagaio.setCorPena("Verde");
            papagaio.setIdade(12);
            papagaio.setMembros(3);
            papagaio.setPeso(3.08f);

            Console.Write("Canguru:\n");
            canguru.usarbolsa();
            canguru.locomover();

            Console.Write("\nCachorro:\n");
            cao.enterrarOsso();
            cao.abanarRabo();

            Console.Write("\n\nTartaruga:\n");
            tartaruga.locomover();

            Console.WriteLine(gato.ToString());
            gato.locomover();
            Console.WriteLine(cobra.ToString());
            cobra.alimentar();
            cobra.locomover();
            Console.WriteLine(papagaio.ToString());
            papagaio.fazerNinho();
            papagaio.locomover();

            Console.ReadKey();

        }
    }
}
