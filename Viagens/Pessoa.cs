using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viagens
{
    public class Pessoa
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public String Documento { get; set; }
        public DateTime Nascimento { get; set; }
        public String Telefone { get; set; }
    }
}
