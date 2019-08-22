using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viagens
{
    class Program
    {
        static void Main(string[] args)
        {

            ModelViagens context = new ModelViagens();
            Aviao a = new Aviao();
            a.Nome = "Aviao 2";

            context.Avioes.Add(a);

            Cidade c1 = new Cidade();
            c1.Nome = "Curitiba";
            
            Cidade c2 = new Cidade();
            c2.Nome = "Sao Paulo";

            Cidade c3 = new Cidade();
            c3.Nome = "Rio de Janeiro";

            context.Cidades.Add(c1);
            context.Cidades.Add(c2);
            context.Cidades.Add(c3);

            Pessoa p = new Pessoa();
            p.Nome = "Joab Rodrigues";

            Voo vooCWBSP = new Voo();
            vooCWBSP.Origem = c1;
            vooCWBSP.Destino = c2;

            Passagem passagem = new Passagem();
            passagem.Passageiro = p;

            context.SaveChanges();

            Console.ReadKey();
        }
    }
}
