using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Novo_Hotel
{
    public class ItemConsumido
    {
        public int fk_Conta_Conta { get; set; }
        public Conta? Conta { get; set; }

        public int ItemConsumidoId { get; set; }
        public Item? Item { get; set; }
    }

}