using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Esquilo veiculo1 = new Esquilo();
            Legacy450 veiculo2 = new Legacy450();
            PicapeS10 veiculo3 = new PicapeS10();
            Fusca veiculo4 = new Fusca();
            Cb200 veiculo5 = new Cb200();
            Caiaque veiculo6 = new Caiaque();

            veiculo1.setAno(1983);
            veiculo1.setCorFuselagem("Preto, Vermelho e Branco");
            veiculo1.setMarca("Esquilo ");

            Console.WriteLine(veiculo1.descricao());
            Console.WriteLine(veiculo1.locomover());
            Console.WriteLine(veiculo1.abastecer());

        
            veiculo2.setCorFuselagem("Cinza");
            veiculo2.setMarca("Legacy");

            Console.WriteLine(veiculo2.descricao());
            Console.WriteLine(veiculo2.locomover());
            Console.WriteLine(veiculo2.abastecer());
            Console.WriteLine("\n");

            veiculo3.setAno(2006);
            veiculo3.setCorCarro("Preto");
            veiculo3.setMarca("Picape S10");
            veiculo3.setPneu(4);
            Console.WriteLine("\n");

            Console.WriteLine(veiculo3.descricao());
            Console.WriteLine(veiculo3.locomover());
            Console.WriteLine(veiculo3.abastecer());
            Console.WriteLine("\n");

            veiculo4.setAno(1967);
            veiculo4.setCorCarro("Amarelo");
            veiculo4.setMarca("Fusca");
            veiculo4.setPneu(4);
            Console.WriteLine("\n");

            Console.WriteLine(veiculo4.descricao());
            Console.WriteLine(veiculo4.locomover());
            Console.WriteLine(veiculo4.abastecer());
            Console.WriteLine("\n");

            veiculo5.setMarca("Cb200");

            Console.WriteLine(veiculo5.descricao());
            Console.WriteLine(veiculo5.locomover());
            Console.WriteLine(veiculo5.abastecer());
            Console.WriteLine("\n");

            veiculo6.setMarca("Caiaque");

            Console.WriteLine(veiculo6.descricao());
            Console.WriteLine(veiculo6.locomover());
            Console.WriteLine(veiculo6.abastecer());






            Console.ReadKey();
        }
    }
}
