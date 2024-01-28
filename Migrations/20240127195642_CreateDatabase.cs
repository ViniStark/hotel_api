using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace novo_hotel.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    EnderecoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pais = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Rua = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.EnderecoID);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoItem = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ValorItem = table.Column<int>(type: "int", nullable: false),
                    Entrega = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "Lavanderias",
                columns: table => new
                {
                    LavanderiaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoServico = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ValorServico = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lavanderias", x => x.LavanderiaID);
                });

            migrationBuilder.CreateTable(
                name: "TiposFuncionario",
                columns: table => new
                {
                    TipoFuncionarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposFuncionario", x => x.TipoFuncionarioID);
                });

            migrationBuilder.CreateTable(
                name: "TiposPaTipoPagamento",
                columns: table => new
                {
                    TipoPagamentoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoTipoPag = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposPaTipoPagamento", x => x.TipoPagamentoID);
                });

            migrationBuilder.CreateTable(
                name: "TiposQuarto",
                columns: table => new
                {
                    TipoQuartoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoQuarto = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ValorQuarto = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposQuarto", x => x.TipoQuartoID);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Nacionalidade = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    EnderecoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteID);
                    table.ForeignKey(
                        name: "FK_Clientes_Enderecos_EnderecoID",
                        column: x => x.EnderecoID,
                        principalTable: "Enderecos",
                        principalColumn: "EnderecoID");
                });

            migrationBuilder.CreateTable(
                name: "Filiais",
                columns: table => new
                {
                    FilialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFilial = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    NumeroQuartos = table.Column<int>(type: "int", nullable: false),
                    QtdEstrelas = table.Column<int>(type: "int", nullable: false),
                    fk_Endereco_IdEndereco = table.Column<int>(type: "int", nullable: false),
                    EnderecoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiais", x => x.FilialID);
                    table.ForeignKey(
                        name: "FK_Filiais_Enderecos_EnderecoID",
                        column: x => x.EnderecoID,
                        principalTable: "Enderecos",
                        principalColumn: "EnderecoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    FuncionarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    fk_Filiais_IdFilial = table.Column<int>(type: "int", nullable: false),
                    FilialID = table.Column<int>(type: "int", nullable: true),
                    fk_TipoFuncionario_IdTipoFuncionario = table.Column<int>(type: "int", nullable: false),
                    TipoFuncionarioID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.FuncionarioID);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Filiais_FilialID",
                        column: x => x.FilialID,
                        principalTable: "Filiais",
                        principalColumn: "FilialID");
                    table.ForeignKey(
                        name: "FK_Funcionarios_TiposFuncionario_TipoFuncionarioID",
                        column: x => x.TipoFuncionarioID,
                        principalTable: "TiposFuncionario",
                        principalColumn: "TipoFuncionarioID");
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    ReservaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cancelado = table.Column<bool>(type: "bit", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumPessoas = table.Column<int>(type: "int", nullable: false),
                    fk_Clientes_IdCliente = table.Column<int>(type: "int", nullable: false),
                    ClienteID = table.Column<int>(type: "int", nullable: true),
                    fk_Funcionarios_IdFuncionario = table.Column<int>(type: "int", nullable: false),
                    FuncionarioID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.ReservaID);
                    table.ForeignKey(
                        name: "FK_Reservas_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ClienteID");
                    table.ForeignKey(
                        name: "FK_Reservas_Funcionarios_FuncionarioID",
                        column: x => x.FuncionarioID,
                        principalTable: "Funcionarios",
                        principalColumn: "FuncionarioID");
                });

            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    ContaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    fk_Reservas_IdReserva = table.Column<int>(type: "int", nullable: false),
                    ReservaID = table.Column<int>(type: "int", nullable: true),
                    ItemID = table.Column<int>(type: "int", nullable: true),
                    LavanderiaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.ContaID);
                    table.ForeignKey(
                        name: "FK_Contas_Itens_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Itens",
                        principalColumn: "ItemID");
                    table.ForeignKey(
                        name: "FK_Contas_Lavanderias_LavanderiaID",
                        column: x => x.LavanderiaID,
                        principalTable: "Lavanderias",
                        principalColumn: "LavanderiaID");
                    table.ForeignKey(
                        name: "FK_Contas_Reservas_ReservaID",
                        column: x => x.ReservaID,
                        principalTable: "Reservas",
                        principalColumn: "ReservaID");
                });

            migrationBuilder.CreateTable(
                name: "Quartos",
                columns: table => new
                {
                    QuartoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapacidadeMaxima = table.Column<int>(type: "int", nullable: false),
                    CapacidadeOpcional = table.Column<bool>(type: "bit", nullable: false),
                    Adaptavel = table.Column<bool>(type: "bit", nullable: false),
                    fk_Filiais_IdFilial = table.Column<int>(type: "int", nullable: false),
                    FilialID = table.Column<int>(type: "int", nullable: true),
                    fk_TiposQuarto_IdQuarto = table.Column<int>(type: "int", nullable: false),
                    TipoQuartoID = table.Column<int>(type: "int", nullable: true),
                    fk_Reservas_IdReserva = table.Column<int>(type: "int", nullable: true),
                    ReservaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quartos", x => x.QuartoID);
                    table.ForeignKey(
                        name: "FK_Quartos_Filiais_FilialID",
                        column: x => x.FilialID,
                        principalTable: "Filiais",
                        principalColumn: "FilialID");
                    table.ForeignKey(
                        name: "FK_Quartos_Reservas_ReservaID",
                        column: x => x.ReservaID,
                        principalTable: "Reservas",
                        principalColumn: "ReservaID");
                    table.ForeignKey(
                        name: "FK_Quartos_TiposQuarto_TipoQuartoID",
                        column: x => x.TipoQuartoID,
                        principalTable: "TiposQuarto",
                        principalColumn: "TipoQuartoID");
                });

            migrationBuilder.CreateTable(
                name: "ItensConsumidos",
                columns: table => new
                {
                    ItemConsumidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fk_Conta_Conta = table.Column<int>(type: "int", nullable: false),
                    ContaID = table.Column<int>(type: "int", nullable: true),
                    ItemID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensConsumidos", x => x.ItemConsumidoId);
                    table.ForeignKey(
                        name: "FK_ItensConsumidos_Contas_ContaID",
                        column: x => x.ContaID,
                        principalTable: "Contas",
                        principalColumn: "ContaID");
                    table.ForeignKey(
                        name: "FK_ItensConsumidos_Itens_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Itens",
                        principalColumn: "ItemID");
                });

            migrationBuilder.CreateTable(
                name: "Pagamentos",
                columns: table => new
                {
                    PagamentoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_NotaFiscal_ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorTotal_NotaFiscal_ = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Codigo_TipoPagamento_ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fk_Conta_IdConta = table.Column<int>(type: "int", nullable: false),
                    ContaID = table.Column<int>(type: "int", nullable: true),
                    fk_TipoPagamento_IdTipoPagamento = table.Column<int>(type: "int", nullable: false),
                    TipoPagamentoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamentos", x => x.PagamentoID);
                    table.ForeignKey(
                        name: "FK_Pagamentos_Contas_ContaID",
                        column: x => x.ContaID,
                        principalTable: "Contas",
                        principalColumn: "ContaID");
                    table.ForeignKey(
                        name: "FK_Pagamentos_TiposPaTipoPagamento_TipoPagamentoID",
                        column: x => x.TipoPagamentoID,
                        principalTable: "TiposPaTipoPagamento",
                        principalColumn: "TipoPagamentoID");
                });

            migrationBuilder.CreateTable(
                name: "ServicosLavanderia",
                columns: table => new
                {
                    ServicoLavanderiaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LavanderiaID = table.Column<int>(type: "int", nullable: true),
                    fk_Conta_IdConta = table.Column<int>(type: "int", nullable: false),
                    ContaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicosLavanderia", x => x.ServicoLavanderiaID);
                    table.ForeignKey(
                        name: "FK_ServicosLavanderia_Contas_ContaID",
                        column: x => x.ContaID,
                        principalTable: "Contas",
                        principalColumn: "ContaID");
                    table.ForeignKey(
                        name: "FK_ServicosLavanderia_Lavanderias_LavanderiaID",
                        column: x => x.LavanderiaID,
                        principalTable: "Lavanderias",
                        principalColumn: "LavanderiaID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EnderecoID",
                table: "Clientes",
                column: "EnderecoID");

            migrationBuilder.CreateIndex(
                name: "IX_Contas_ItemID",
                table: "Contas",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Contas_LavanderiaID",
                table: "Contas",
                column: "LavanderiaID");

            migrationBuilder.CreateIndex(
                name: "IX_Contas_ReservaID",
                table: "Contas",
                column: "ReservaID");

            migrationBuilder.CreateIndex(
                name: "IX_Filiais_EnderecoID",
                table: "Filiais",
                column: "EnderecoID");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_FilialID",
                table: "Funcionarios",
                column: "FilialID");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_TipoFuncionarioID",
                table: "Funcionarios",
                column: "TipoFuncionarioID");

            migrationBuilder.CreateIndex(
                name: "IX_ItensConsumidos_ContaID",
                table: "ItensConsumidos",
                column: "ContaID");

            migrationBuilder.CreateIndex(
                name: "IX_ItensConsumidos_ItemID",
                table: "ItensConsumidos",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_ContaID",
                table: "Pagamentos",
                column: "ContaID");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_TipoPagamentoID",
                table: "Pagamentos",
                column: "TipoPagamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_Quartos_FilialID",
                table: "Quartos",
                column: "FilialID");

            migrationBuilder.CreateIndex(
                name: "IX_Quartos_ReservaID",
                table: "Quartos",
                column: "ReservaID");

            migrationBuilder.CreateIndex(
                name: "IX_Quartos_TipoQuartoID",
                table: "Quartos",
                column: "TipoQuartoID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ClienteID",
                table: "Reservas",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_FuncionarioID",
                table: "Reservas",
                column: "FuncionarioID");

            migrationBuilder.CreateIndex(
                name: "IX_ServicosLavanderia_ContaID",
                table: "ServicosLavanderia",
                column: "ContaID");

            migrationBuilder.CreateIndex(
                name: "IX_ServicosLavanderia_LavanderiaID",
                table: "ServicosLavanderia",
                column: "LavanderiaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItensConsumidos");

            migrationBuilder.DropTable(
                name: "Pagamentos");

            migrationBuilder.DropTable(
                name: "Quartos");

            migrationBuilder.DropTable(
                name: "ServicosLavanderia");

            migrationBuilder.DropTable(
                name: "TiposPaTipoPagamento");

            migrationBuilder.DropTable(
                name: "TiposQuarto");

            migrationBuilder.DropTable(
                name: "Contas");

            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "Lavanderias");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Filiais");

            migrationBuilder.DropTable(
                name: "TiposFuncionario");

            migrationBuilder.DropTable(
                name: "Enderecos");
        }
    }
}
