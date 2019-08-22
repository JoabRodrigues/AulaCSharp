using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7 };

            var numQuery =
                from number in numbers
                where (number % 2) == 0
                select number;

            foreach(int num in numQuery){
                Console.WriteLine("Numero:" + num);
            }

            Cidade c1 = new Cidade();
            c1.Nome = "Curitiba";
            Cidade c2 = new Cidade();
            c2.Nome = "Sao Paulo";

            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa p3 = new Pessoa();
            Pessoa p4 = new Pessoa();
            Pessoa p5 = new Pessoa();
            Pessoa p6 = new Pessoa();

            p1.Nome = "Pessoa 1";
            p1.Nascimento = new DateTime(1998, 01, 02);
            p1.Cidade = c1;


            p2.Nome = "Pessoa 2";
            p2.Nascimento = new DateTime(1989, 12, 10);
            p2.Cidade = c1;


            p3.Nome = "Pessoa 3";
            p3.Nascimento = new DateTime(1991, 10, 23);
            p3.Cidade = c2;

            p4.Nome = "Pessoa 4";
            p4.Nascimento = new DateTime(2007, 10, 23);
            p4.Cidade = c1;

            p5.Nome = "Pessoa 5";
            p5.Nascimento = new DateTime(2010, 10, 23);
            p5.Cidade = c2;

            p6.Nome = "Pessoa 6";
            p6.Nascimento = new DateTime(1999, 10, 23);
            p6.Cidade = c1;

            pessoas.Add(p1);
            pessoas.Add(p2);
            pessoas.Add(p3);
            pessoas.Add(p4);
            pessoas.Add(p5);
            pessoas.Add(p6);

            var resultado =
                from pessoa in pessoas
                where (DateTime.Now.Year - pessoa.Nascimento.Year) >= 18 
                && (DateTime.Now.Year - pessoa.Nascimento.Year) <= 70
                orderby pessoa.Nascimento ascending
                group pessoa by pessoa.Cidade;
            
            foreach (var x in resultado)
            {
                Console.WriteLine(x.Key.Nome);
                foreach(var result in x)
                {
                    Console.WriteLine(result.Nome);
                }
                
            }

            Console.ReadKey();

        }
    }
}
