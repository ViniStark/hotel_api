using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Novo_Hotel
{
    public class Filial
    {
        public int FilialID { get; set; }
        [StringLength(64)]
        public string? NomeFilial { get; set; }
        public int NumeroQuartos { get; set; }
        public int QtdEstrelas { get; set; }
        
        public int fk_Endereco_IdEndereco { get; set; }
        public Endereco Endereco { get; set; } = null;

        public ICollection<Quarto> Quartos { get; set; } = new List<Quarto>();
        public ICollection<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();
    }
}