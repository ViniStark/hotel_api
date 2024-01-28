using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Novo_Hotel
{
    public class Cliente
    {
        public int ClienteID {get; set;}
        [StringLength(64)]
        public string? Nome {get; set;}
        [StringLength(64)]
        public string? Nacionalidade {get;set;}
        [StringLength(64)]
        public string? Email {get;set;}
        [StringLength(64)]
        public string? Telefone {get;set;}

        public Endereco? Endereco { get; set; }
        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

    }
}