using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hawk.Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    RegistroAtivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Administrador = table.Column<bool>(nullable: false),
                    RegistroAtivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Telefone = table.Column<string>(nullable: true),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Cnpj = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Ramo = table.Column<string>(nullable: true),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cartoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<string>(nullable: true),
                    NomeProprietario = table.Column<string>(nullable: true),
                    DataVencimento = table.Column<DateTime>(nullable: false),
                    Cvc = table.Column<string>(nullable: true),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cartoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cartoes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EnderecosClientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Estado = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecosClientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnderecosClientes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AvaliacoesEmpresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comentario = table.Column<string>(nullable: true),
                    Nota = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacoesEmpresas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvaliacoesEmpresas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EnderecosEmpresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Estado = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecosEmpresas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnderecosEmpresas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    ValorCusto = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ValorVenda = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Altura = table.Column<int>(nullable: false),
                    Largura = table.Column<int>(nullable: false),
                    Comprimento = table.Column<int>(nullable: false),
                    Peso = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Promocao = table.Column<bool>(nullable: false),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    NomeArquivo = table.Column<string>(nullable: true),
                    NomeHash = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produtos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AvaliacoesProdutos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comentario = table.Column<string>(nullable: true),
                    Nota = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacoesProdutos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvaliacoesProdutos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estoques",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(nullable: false),
                    Entrada = table.Column<string>(nullable: true),
                    DataEntrada = table.Column<DateTime>(nullable: false),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estoques_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estoques_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItensCompras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensCompras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItensCompras_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProdutosFavoritos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosFavoritos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutosFavoritos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProdutosFavoritos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carrinhos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(nullable: false),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    ItemCompraId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinhos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carrinhos_ItensCompras_ItemCompraId",
                        column: x => x.ItemCompraId,
                        principalTable: "ItensCompras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ValorTotal = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Desconto = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    CarrinhoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compras_Carrinhos_CarrinhoId",
                        column: x => x.CarrinhoId,
                        principalTable: "Carrinhos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compras_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Financas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mes = table.Column<string>(nullable: true),
                    ValorCusto = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ValorVenda = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Lucro = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    CompraId = table.Column<int>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Financas_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Financas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Nome", "RegistroAtivo" },
                values: new object[,]
                {
                    { 1, "Eletronicos", true },
                    { 2, "Calabresa", true }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Administrador", "Email", "Nome", "RegistroAtivo", "Senha" },
                values: new object[,]
                {
                    { 1, false, "erickbaron@gmail.com", "Erick", true, "1234" },
                    { 2, true, "Jozinho@gmail.com", "Joao", true, "4321" }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Nome", "RegistroAtivo", "Telefone", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "59315617061", new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "irineu", true, "2036466360", 1 },
                    { 2, "59315639061", new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "jose", true, "2012466360", 1 }
                });

            migrationBuilder.InsertData(
                table: "Empresas",
                columns: new[] { "Id", "Cnpj", "Nome", "Ramo", "RegistroAtivo", "Telefone", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "81.197.017/0001-82", "WEG", "lojinha", true, "2036466360", 1 },
                    { 2, "83.757.980/0001-07", "Hanes", "comida", true, "2036466370", 2 }
                });

            migrationBuilder.InsertData(
                table: "AvaliacoesEmpresas",
                columns: new[] { "Id", "Comentario", "EmpresaId", "Nota", "RegistroAtivo" },
                values: new object[,]
                {
                    { 1, "hfgghsdgfhsdgfjhgs", 1, 5m, true },
                    { 2, "ehuehuehueheu", 1, 4m, true }
                });

            migrationBuilder.InsertData(
                table: "Cartoes",
                columns: new[] { "Id", "ClienteId", "Cvc", "DataVencimento", "NomeProprietario", "Numero", "RegistroAtivo" },
                values: new object[,]
                {
                    { 1, 1, "123", new DateTime(2010, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "jose", "123576123", true },
                    { 2, 1, "123", new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "joao", "12357343", true }
                });

            migrationBuilder.InsertData(
                table: "EnderecosClientes",
                columns: new[] { "Id", "Cep", "Cidade", "ClienteId", "Complemento", "Estado", "Logradouro", "Numero", "RegistroAtivo" },
                values: new object[,]
                {
                    { 1, "04180112", "Sao Paulo", 1, " ", "Sao Paulo", "virando a esquina", "1222", true },
                    { 2, "04180113", "rio de janeiro", 2, " ", "Rio de janeiro", "Rua principal", "123", true }
                });

            migrationBuilder.InsertData(
                table: "EnderecosEmpresas",
                columns: new[] { "Id", "Cep", "Cidade", "Complemento", "EmpresaId", "Estado", "Logradouro", "Numero", "RegistroAtivo" },
                values: new object[,]
                {
                    { 1, "04180112", "Sao Paulo", " ", 1, "Sao Paulo", "virando a esquina", "1222", true },
                    { 2, "04180113", "rio de janeiro", " ", 2, "Rio de janeiro", "Rua principal", "123", true }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Altura", "CategoriaId", "Comprimento", "Descricao", "EmpresaId", "Largura", "Nome", "NomeArquivo", "NomeHash", "Peso", "Promocao", "RegistroAtivo", "ValorCusto", "ValorVenda" },
                values: new object[,]
                {
                    { 1, 1, 1, 3, "se derubar abre uma cratera", 1, 2, "nokia tijolao", "imagem.jpg", "", 10m, false, true, 2m, 10m },
                    { 2, 2, 2, 2, "o kiko sempre quis uma ", 2, 2, "bola quadrada", "imagem.jpg", "", 10m, false, true, 3m, 100m }
                });

            migrationBuilder.InsertData(
                table: "AvaliacoesProdutos",
                columns: new[] { "Id", "Comentario", "Nota", "ProdutoId", "RegistroAtivo" },
                values: new object[,]
                {
                    { 1, "abfkjgadkfgakf", 5m, 1, true },
                    { 2, "fçaksdçmakd", 5m, 1, true }
                });

            migrationBuilder.InsertData(
                table: "Estoques",
                columns: new[] { "Id", "DataEntrada", "EmpresaId", "Entrada", "ProdutoId", "Quantidade", "RegistroAtivo" },
                values: new object[,]
                {
                    { 1, new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "entrada", 1, 2, true },
                    { 2, new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "saida", 2, 32, true }
                });

            migrationBuilder.InsertData(
                table: "ItensCompras",
                columns: new[] { "Id", "ProdutoId", "RegistroAtivo" },
                values: new object[,]
                {
                    { 1, 1, true },
                    { 2, 2, true }
                });

            migrationBuilder.InsertData(
                table: "ProdutosFavoritos",
                columns: new[] { "Id", "ClienteId", "ProdutoId", "RegistroAtivo" },
                values: new object[,]
                {
                    { 1, 1, 1, true },
                    { 2, 2, 2, true }
                });

            migrationBuilder.InsertData(
                table: "Carrinhos",
                columns: new[] { "Id", "ItemCompraId", "Quantidade", "RegistroAtivo" },
                values: new object[] { 1, 1, 2, true });

            migrationBuilder.InsertData(
                table: "Carrinhos",
                columns: new[] { "Id", "ItemCompraId", "Quantidade", "RegistroAtivo" },
                values: new object[] { 2, 1, 2, true });

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "Id", "CarrinhoId", "ClienteId", "Desconto", "RegistroAtivo", "ValorTotal" },
                values: new object[] { 1, 1, 1, 0m, true, 12333m });

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "Id", "CarrinhoId", "ClienteId", "Desconto", "RegistroAtivo", "ValorTotal" },
                values: new object[] { 2, 1, 2, 2m, true, 1433m });

            migrationBuilder.InsertData(
                table: "Financas",
                columns: new[] { "Id", "CompraId", "EmpresaId", "Lucro", "Mes", "RegistroAtivo", "ValorCusto", "ValorVenda" },
                values: new object[] { 1, 1, 1, 198m, null, true, 2m, 200m });

            migrationBuilder.InsertData(
                table: "Financas",
                columns: new[] { "Id", "CompraId", "EmpresaId", "Lucro", "Mes", "RegistroAtivo", "ValorCusto", "ValorVenda" },
                values: new object[] { 2, 2, 2, 300m, null, true, 3m, 303m });

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacoesEmpresas_EmpresaId",
                table: "AvaliacoesEmpresas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacoesProdutos_ProdutoId",
                table: "AvaliacoesProdutos",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinhos_ItemCompraId",
                table: "Carrinhos",
                column: "ItemCompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Cartoes_ClienteId",
                table: "Cartoes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_UsuarioId",
                table: "Clientes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_CarrinhoId",
                table: "Compras",
                column: "CarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ClienteId",
                table: "Compras",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_UsuarioId",
                table: "Empresas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecosClientes_ClienteId",
                table: "EnderecosClientes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecosEmpresas_EmpresaId",
                table: "EnderecosEmpresas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_EmpresaId",
                table: "Estoques",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_ProdutoId",
                table: "Estoques",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Financas_CompraId",
                table: "Financas",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Financas_EmpresaId",
                table: "Financas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensCompras_ProdutoId",
                table: "ItensCompras",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_EmpresaId",
                table: "Produtos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosFavoritos_ClienteId",
                table: "ProdutosFavoritos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosFavoritos_ProdutoId",
                table: "ProdutosFavoritos",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvaliacoesEmpresas");

            migrationBuilder.DropTable(
                name: "AvaliacoesProdutos");

            migrationBuilder.DropTable(
                name: "Cartoes");

            migrationBuilder.DropTable(
                name: "EnderecosClientes");

            migrationBuilder.DropTable(
                name: "EnderecosEmpresas");

            migrationBuilder.DropTable(
                name: "Estoques");

            migrationBuilder.DropTable(
                name: "Financas");

            migrationBuilder.DropTable(
                name: "ProdutosFavoritos");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Carrinhos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "ItensCompras");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
