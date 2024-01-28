using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Novo_Hotel
{
    public class Quarto
    {
        public int QuartoID { get; set; }
        public int CapacidadeMaxima { get; set; }
        public bool CapacidadeOpcional { get; set; }
        public bool Adaptavel { get; set; }

        public int fk_Filiais_IdFilial { get; set; }
        public Filial? Filial { get; set; }

        public int fk_TiposQuarto_IdQuarto { get; set; }
        public TipoQuarto? TipoQuarto { get; set; }

        public int? fk_Reservas_IdReserva { get; set; }
        public Reserva? Reserva { get; set; }
    }
}