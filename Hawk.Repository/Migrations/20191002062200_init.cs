using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hawk.Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

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
                name: "AspNetUsers",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    nome = table.Column<string>(maxLength: 256, nullable: true),
                    senha = table.Column<string>(nullable: true),
                    registro_ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<int>(nullable: true),
                    RoleId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId1",
                        column: x => x.RoleId1,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carrinhos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    RegistroAtivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinhos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carrinhos_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_Clientes_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
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
                    Estado = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresas_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
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
                    EmpresaId = table.Column<int>(nullable: true),
                    CategoriaId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    UrlImagem = table.Column<string>(nullable: true),
                    UrlImagemHash = table.Column<string>(nullable: true),
                    ProdutoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Quantidade = table.Column<int>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    CompraId = table.Column<int>(nullable: false),
                    CarrinhoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensCompras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItensCompras_Carrinhos_CarrinhoId",
                        column: x => x.CarrinhoId,
                        principalTable: "Carrinhos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItensCompras_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItensCompras_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
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
                schema: "dbo",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "senha", "PhoneNumber", "PhoneNumberConfirmed", "registro_ativo", "SecurityStamp", "TwoFactorEnabled", "nome" },
                values: new object[,]
                {
                    { 1, 0, "53db4f68-e72f-40bf-92f8-f08ccb96f13a", "erick@gmail.com", false, false, null, "ERICK@GMAIL.COM", "Erick", "AQAAAAEAACcQAAAAELDMbLMCmZrqbqcxF5vpVa7kBAFmQLv9eOZZ6xZ1nuMJLq1JBOEzS+vFfMZH2d0zcw==", null, false, true, null, false, "Erick" },
                    { 2, 0, "8000d87f-b704-4796-8982-089a589bc1bc", "joao@gmail.com", false, false, null, "JOAO@GMAIL.COM", "Joao", "AQAAAAEAACcQAAAAELDMbLMCmZrqbqcxF5vpVa7kBAFmQLv9eOZZ6xZ1nuMJLq1JBOEzS+vFfMZH2d0zcw==", null, false, true, null, false, "Joao" }
                });

            migrationBuilder.InsertData(
                table: "Carrinhos",
                columns: new[] { "Id", "RegistroAtivo", "UsuarioId", "ValorTotal" },
                values: new object[,]
                {
                    { 1, true, 1, 0m },
                    { 2, true, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Nome", "RegistroAtivo", "Telefone", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "59315617061", new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "irineu", true, "2036466360", 1 },
                    { 2, "59315639061", new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "jose", true, "2012466360", 2 }
                });

            migrationBuilder.InsertData(
                table: "Empresas",
                columns: new[] { "Id", "Cep", "Cidade", "Cnpj", "Complemento", "Estado", "Logradouro", "Nome", "Numero", "Ramo", "RegistroAtivo", "Telefone", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "04180112", "Sao Paulo", "81.197.017/0001-82", "Casa", "Sao Paulo", "virando a esquina", "WEG", "1222", "lojinha", true, "2036466360", 1 },
                    { 2, "04180112", "Terezina", "83.757.980/0001-07", "Apartamento", "Piaui", "Rua Piaui", "Mercosul", "1222", "óculos", true, "2036466370", 2 }
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
                table: "Compras",
                columns: new[] { "Id", "CarrinhoId", "ClienteId", "Desconto", "RegistroAtivo", "ValorTotal" },
                values: new object[,]
                {
                    { 1, 1, 1, 0m, true, 12333m },
                    { 2, 1, 2, 2m, true, 1433m }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Altura", "CategoriaId", "Comprimento", "Descricao", "Discriminator", "EmpresaId", "Largura", "Nome", "NomeArquivo", "NomeHash", "Peso", "Promocao", "RegistroAtivo", "ValorCusto", "ValorVenda" },
                values: new object[,]
                {
                    { 1, 1, 1, 3, "se derubar abre uma cratera", "Produto", 1, 2, "nokia tijolao", "imagem2.jpg", "", 10m, false, true, 2m, 10m },
                    { 3, 1, 1, 3, "dasdadatera", "Produto", 1, 2, "asdsadasd asdasdasdasd", "imagem2.jpg", "", 10m, false, true, 2m, 10m },
                    { 2, 2, 2, 2, "o kiko sempre quis uma ", "Produto", 2, 2, "bola quadrada", "imagem.jpg", "", 10m, false, true, 3m, 100m },
                    { 4, 2, 2, 2, "sdadaads ", "Produto", 2, 2, "blablabla blabla", "imagem.jpg", "", 10m, false, true, 3m, 100m },
                    { 5, 2, 2, 2, "sdadaads ", "Produto", 2, 2, "blablabla blabla", "imagem.jpg", "", 10m, false, true, 3m, 100m },
                    { 6, 2, 2, 2, "sdadaads ", "Produto", 2, 2, "blablabla blabla", "imagem.jpg", "", 10m, false, true, 3m, 100m },
                    { 7, 2, 2, 2, "sdadaads ", "Produto", 2, 2, "blablabla blabla", "imagem.jpg", "", 10m, false, true, 3m, 100m },
                    { 8, 2, 2, 2, "sdadaads ", "Produto", 2, 2, "blablabla blabla", "imagem.jpg", "", 10m, false, true, 3m, 100m }
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
                columns: new[] { "Id", "CarrinhoId", "CompraId", "ProdutoId", "Quantidade", "RegistroAtivo", "Valor" },
                values: new object[,]
                {
                    { 1, null, 1, 1, 0, true, 0m },
                    { 2, null, 1, 2, 0, true, 0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId1",
                table: "AspNetUserRoles",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId1",
                table: "AspNetUserRoles",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinhos_UsuarioId",
                table: "Carrinhos",
                column: "UsuarioId");

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
                name: "IX_Estoques_EmpresaId",
                table: "Estoques",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_ProdutoId",
                table: "Estoques",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensCompras_CarrinhoId",
                table: "ItensCompras",
                column: "CarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensCompras_CompraId",
                table: "ItensCompras",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensCompras_ProdutoId",
                table: "ItensCompras",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ProdutoId",
                table: "Produtos",
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
                name: "EmailIndex",
                schema: "dbo",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "dbo",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cartoes");

            migrationBuilder.DropTable(
                name: "EnderecosClientes");

            migrationBuilder.DropTable(
                name: "Estoques");

            migrationBuilder.DropTable(
                name: "ItensCompras");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Carrinhos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "dbo");
        }
    }
}
