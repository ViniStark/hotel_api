using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Novo_Hotel
{
    public class Item
    {
        public int ItemID { get; set; }
        [StringLength(64)]
        public string? DescricaoItem { get; set; }
        public int ValorItem { get; set; }
        public bool Entrega { get; set; }

        public ICollection<Conta> Contas { get; set; } = new List<Conta>();
    }
}