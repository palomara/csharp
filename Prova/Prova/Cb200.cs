using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova
{
    class Cb200 : Motocicleta
    {
        public override string locomover()
        {
            return "Locomoção: Tração roda traseira";
        }

        public override string abastecer()
        {
            return "Abastecimento: Álcool";
        }

    }
}

