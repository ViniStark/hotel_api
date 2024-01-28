using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Novo_Hotel
{
    public class TipoPagamento
    {
        public int TipoPagamentoID { get; set; }
        [StringLength(64)]
        public string? DescricaoTipoPag { get; set; }

        public ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
    }

}