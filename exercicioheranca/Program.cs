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
            Animal animal1 = new Animal();
            Animal animal2 = new Animal();
            Animal animal3 = new Animal();
            Mamifero mamifero1 = new Mamifero();
            Reptil reptil1 = new Reptil();
            Ave ave1 = new Ave();


            animal1.setPeso (68f);
            animal1.setIdade(4);
            animal1.setMembros(3);
            animal2.setPeso(23f);
            animal2.setIdade(3);
            animal2.setMembros(5);
            animal3.setPeso(4f);
            animal3.setIdade(2);
            animal3.setMembros(6);
            mamifero1.setCorPelo("Marrom");
            mamifero1.setRaca("Siamês");
            reptil1.setCorEscama("Verde");
            ave1.setCorPena("Branca");

            Console.WriteLine(animal1.ToString());
            Console.WriteLine(animal2.ToString());
            Console.WriteLine(animal3.ToString());
            Console.WriteLine(mamifero1.ToString());
            Console.WriteLine(reptil1.ToString());
            Console.WriteLine(ave1.ToString());
            


            Console.ReadKey();

        }
    }
}
