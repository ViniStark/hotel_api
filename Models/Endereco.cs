using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Novo_Hotel
{
    public class Endereco
    {
        public int EnderecoID { get; set; }
        [StringLength(64)]
        public string? Pais { get; set; }
        [StringLength(64)]
        public string? Estado { get; set; }
        [StringLength(64)]
        public string? Cidade { get; set; }
        [StringLength(64)]
        public string? Rua { get; set; }
        public int Numero { get; set; }
        [StringLength(64)]
        public string? Complemento { get; set; }

    }
}