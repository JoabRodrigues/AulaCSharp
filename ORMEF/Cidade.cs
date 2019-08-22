using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMEF
{
    public class Cidade
    {
        public int Id { get; set; }
        [Column("NomeCidade")]
        public String Nome { get; set; }
    }
}
