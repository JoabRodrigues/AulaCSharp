using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho do arquivo .txt:");
            String Path = Console.ReadLine();

            EditorTexto EditorTexto = new EditorTexto();

            try
            {
                EditorTexto.LerArquivo(Path);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Erro na leitura do arquivo. ", Path, e.Message);
            }
            Console.ReadKey();

            Console.WriteLine("Digite o novo conteudo do arquivo:");
            String NovoTexto = Console.ReadLine();

            try
            {
                EditorTexto.EditarArquivo(Path, NovoTexto);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Erro na gravação do arquivo. " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
