using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Novo_Hotel
{
    public class Funcionario
    {
        public int FuncionarioID { get; set; }
        [StringLength(64)]
        public string? NomeFuncionario { get; set; }

        public int fk_Filiais_IdFilial { get; set; }
        public Filial? Filial { get; set; }

        public int fk_TipoFuncionario_IdTipoFuncionario { get; set; }
        public TipoFuncionario? TipoFuncionario { get; set; }

        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}