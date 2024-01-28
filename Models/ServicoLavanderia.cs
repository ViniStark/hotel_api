using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Novo_Hotel
{
    public class ServicoLavanderia
    {
        public int ServicoLavanderiaID { get; set; }
        public Lavanderia? Lavanderia { get; set; }

        public int fk_Conta_IdConta { get; set; }
        public Conta? Conta { get; set; }
    }

}