using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viagens
{
    [Table("Avioes")]
    public class Aviao
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public List<Voo> Voos { get; set; }
    }
}
