using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viagens
{
    public class Poltrona
    {
        public int Id { get; set; }
        public int Coluna { get; set; }
        public int Fileira { get; set; }
        public String Assento { get; set; }
        public Voo Voo { get; set; }
    }
}
