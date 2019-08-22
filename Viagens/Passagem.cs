using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viagens
{
    [Table("Passagens")]
    public class Passagem
    {
        public int Id { get; set; }
        public Cidade Origem { get; set; }
        public Cidade Destino { get; set; }
        public Voo Voo { get; set; }
        public Poltrona Assento { get; set; }
        public Double Valor { get; set; }
        public Pessoa Passageiro { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
    }
}
