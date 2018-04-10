using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova
{
    class Esquilo : Aeronave 
    {
        public override string locomover()
        {
            return "Locomoção: via Hélice";
        }

        public override string abastecer()
        {
            return "Abastecimento: Diesel";
        }
    }
}
