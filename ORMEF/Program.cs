using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMEF
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelPessoa context = new ModelPessoa();

            Pessoa p = new Pessoa()
            {
                Nome = "Joab",
                Nascimento = new DateTime(2019,12,15)
            
            };

            
            //context.Pessoas.Add(p);


            //context.SaveChanges();

            var resultado =
                (from pessoa in context.Pessoas
                where pessoa.Nome == p.Nome
                select p).FirstOrDefault();

            if(resultado == null)
            {
                resultado = context.Pessoas.Add(p);
            }

            Cidade cidade = null;
                  
            var resultadoCidade = (from c in context.Cidades
                                   where c.Nome == "Curitiba" 
                                   select c).FirstOrDefault();
            if (resultadoCidade == null)
            {
                cidade = new Cidade();
                cidade.Nome = "Curitiba";
            }

            resultado.Cidade = cidade;

            context.SaveChanges();
            




            Console.ReadKey();
        }
    }
}
