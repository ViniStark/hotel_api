using Novo_Hotel;
using Microsoft.EntityFrameworkCore;

namespace Novo_Hotel.Models
{
    public class Novo_HotelContext : DbContext
    {
        public DbSet<Cliente> Clientes {get; set;} = null!;
        public DbSet<Conta> Contas {get; set;} = null!;
        public DbSet<Endereco> Enderecos {get; set;} = null!;
        public DbSet<Filial> Filiais {get; set;} = null!;
        public DbSet<Funcionario> Funcionarios {get; set;} = null!;
        public DbSet<Item> Itens {get; set;} = null!;
        public DbSet<ItemConsumido> ItensConsumidos {get; set;} = null!;
        public DbSet<Lavanderia> Lavanderias {get; set;} = null!;
        public DbSet<Pagamento> Pagamentos {get; set;} = null!;
        public DbSet<Quarto> Quartos {get; set;} = null!;
        public DbSet<Reserva> Reservas {get; set;} = null!;
        public DbSet<ServicoLavanderia> ServicosLavanderia {get; set;} = null!;
        public DbSet<TipoFuncionario> TiposFuncionario {get; set;} = null!;
        public DbSet<TipoQuarto> TiposQuarto {get; set;} = null!;
        public DbSet<TipoPagamento> TiposPagamento {get; set;} = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-0QLLLM86\SQLEXPRESS;Database=Novo_Hotel;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }
    }
}