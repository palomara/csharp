using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio
{
   public class Canguru : Mamifero 
    {
       public override void locomover()
       {
           Console.Write("Pulando.\n");
       }

       public void usarbolsa()
       {
           Console.Write("Usando a bolsa.\n");
       }

    }
}
