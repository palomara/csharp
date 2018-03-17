using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio
{
    public class Ave : Animal
    {
        private string corPena;

        public void fazerNinho()
        {
            Console.WriteLine("Construindo um ninho!");
        }
        public string getCorPena()
        {
            return corPena;
        }
        public void setCorPena(string corPena)
        {
            this.corPena = corPena;
        }
        public override string ToString()
        {
            return "Ave{" + "cor da pena:" + corPena + '}';
        }
    }
}
