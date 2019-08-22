using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    public class Pessoa
    {
        public String Nome { get; set; }

        public override  String ToString()
        {
            return Nome;
        }
        public virtual void Falar()
        {
            Console.WriteLine("Pessoa Falou.");
        }
    }
}