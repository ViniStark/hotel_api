using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Novo_Hotel
{
    public class Conta
    {
        public int ContaID { get; set; }
        public decimal Valor { get; set; }

        public int fk_Reservas_IdReserva { get; set; }
        public Reserva? Reserva { get; set; }
    }

}