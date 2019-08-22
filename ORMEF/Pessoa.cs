using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMEF
{
    public class Pessoa
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public Cidade Cidade { get; set; }
    }
}
