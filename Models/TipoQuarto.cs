using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Novo_Hotel
{
    public class TipoQuarto
    {
        public int TipoQuartoID { get; set; }
        [StringLength(64)]
        public string? DescricaoQuarto { get; set; }
        public decimal ValorQuarto { get; set; }

        public ICollection<Quarto> Quartos { get; set; } = new List<Quarto>();
    }
}