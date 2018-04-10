using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova
{
    class Legacy450 : Aeronave
    {
        public override string locomover()
        {
            return "Locomoção: por Turbina";
        }

        public override string abastecer()
        {
            return "Abastecimento: Querosene";
        }

        public string decolar(string clima)
        {
            if (clima == "sol")
            {
                return "Voo: normal";
            }

            if (clima == "chuva" && clima == "nublado")
            {
                return "Voo: por instrumento";
            }

            else
            {
                return "Sem voo";
            }
        }

        public int decolar(int horario)
        {
            if (horario >= 1 && horario <= 12)
            {
                Console.WriteLine("Manhã - altitude mais alta (de 01:00 às 12:00)");
            }

            if (horario > 12 && horario <= 18)
            {
                Console.WriteLine("Tarde – altitude média (das 12:01 às 18:00)");
            }

            else
            {
                Console.WriteLine("Noite – altitude baixa (das 18:01 às 00:59)");
            }
            return horario;
        }

        public Boolean decolar(Boolean passageiro)
        {
            if (passageiro == true)
            {
                Console.WriteLine("*Servir refeição*");
            }

            else
            {
                Console.WriteLine("*Amarrar bem a carga*");
            }
            return passageiro;
        }
    }
}
    

