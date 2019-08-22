using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecao
{
    class EditorTexto
    {
        public void LerArquivo(String Path)
        {
            int Index = 0;
            FileInfo fi = new FileInfo(Path);
            System.IO.StreamReader Arquivo = new System.IO.StreamReader(Path);
            char[] Buffer = new char[fi.Length];

                Arquivo.ReadBlock(Buffer, Index, Buffer.Length);
                String str = new string(Buffer);
                Console.WriteLine(str);
                Console.WriteLine(fi.Length);

            Arquivo.Close();
        }
            
        public void EditarArquivo(String Path, String novoTexto)
        {
            System.IO.File.WriteAllText(Path,novoTexto);
        }
    }
}
