using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Novo_Hotel
{
    public class Reserva
    {
        public int ReservaID { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public bool Cancelado { get; set; }
        public decimal Valor { get; set; }
        public int NumPessoas { get; set; }

        public int fk_Clientes_IdCliente { get; set; }
        public Cliente? Cliente { get; set; }

        public int fk_Funcionarios_IdFuncionario { get; set; }
        public Funcionario? Funcionario { get; set; }

        public ICollection<Quarto> Quartos { get; set; } = new List<Quarto>();
    }
}