using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viagens
{
    [Table("FormasPagamentos")]
    public class FormaPagamento
    {
        public int Id { get; set; }
        public String Pagamento { get; set; }
        public Decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }
    }
}
