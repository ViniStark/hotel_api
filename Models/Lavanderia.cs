using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Novo_Hotel
{
    public class Lavanderia
    {
        public int LavanderiaID { get; set; }
        [StringLength(64)]
        public string? DescricaoServico { get; set; }
        public decimal ValorServico { get; set; }

        public ICollection<Conta> Contas { get; set; } = new List<Conta>();
    }
}