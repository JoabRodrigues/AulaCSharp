using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    public class Homem:Pessoa
    {

        public override void Falar()
        {
            Console.WriteLine("Homem falou.");
        }

    }
}