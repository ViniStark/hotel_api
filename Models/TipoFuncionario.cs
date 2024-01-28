using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Novo_Hotel
{
    public class TipoFuncionario
    {
        public int TipoFuncionarioID { get; set; }
        [StringLength(64)]
        public string? Descricao { get; set; }

        public ICollection<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();
    }

}