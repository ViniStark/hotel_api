using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Novo_Hotel
{
    public class Pagamento
    {
        public int PagamentoID { get; set; }
        public DateTime Data_NotaFiscal_ { get; set; }
        public decimal ValorTotal_NotaFiscal_ { get; set; }
        public DateTime Codigo_TipoPagamento_ { get; set; }

        public int fk_Conta_IdConta { get; set; }
        public Conta? Conta { get; set; }

        public int fk_TipoPagamento_IdTipoPagamento { get; set; }
        public TipoPagamento? TipoPagamento { get; set; }
    }
}