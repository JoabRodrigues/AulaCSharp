using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            p.Falar();

            Homem h = new Homem();
            h.Falar();

            Mulher m = new Mulher();
            m.Falar();


            Pessoa p2 = new Homem();
            p2.Falar();

            Pessoa p3 = new Mulher();
            p3.Falar();
            p3.Nome = "Nome da Pessoa";

            Console.WriteLine(p3.ToString());

            Console.ReadKey();

        }
    }
}
