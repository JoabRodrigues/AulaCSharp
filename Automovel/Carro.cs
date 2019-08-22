using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automovel
{
    public class Carro
    {
        public DateTime Fabricacao { get; set; }
        public int Portas { get; set; }
        public CorCarro Cor { get; set; }
        public Motor Motor { get; set; }
    }
}
