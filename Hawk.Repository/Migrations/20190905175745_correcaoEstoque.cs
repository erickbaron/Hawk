using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hawk.Repository.Migrations
{
    public partial class correcaoEstoque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "RegistroAtivo",
                table: "Estoques",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Administrador", "Email", "Nome", "RegistroAtivo", "Senha" },
                values: new object[] { 1, false, "erickbaron@gmail.com", "Erick", true, "1234" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Administrador", "Email", "Nome", "RegistroAtivo", "Senha" },
                values: new object[] { 2, true, "Jozinho@gmail.com", "Joao", true, "4321" });

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
                table: "Compras",
                columns: new[] { "Id", "ClienteId", "Desconto", "RegistroAtivo", "ValorTotal" },
                values: new object[,]
                {
                    { 1, 1, 0m, true, 12333m },
                    { 2, 2, 2m, true, 1433m }
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
                columns: new[] { "Id", "Altura", "CategoriaId", "Comprimento", "Descricao", "EmpresaId", "Largura", "Nome", "Peso", "Promocao", "RegistroAtivo", "ValorCusto", "ValorVenda" },
                values: new object[,]
                {
                    { 1, 1, 1, 3, "se derubar abre uma cratera", 1, 2, "nokia tijolao", 10m, false, true, 2m, 10m },
                    { 2, 2, 2, 2, "o kiko sempre quis uma ", 2, 2, "bola quadrada", 10m, false, true, 3m, 100m }
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
                    { 1, new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 2, false },
                    { 2, new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, 2, 32, false }
                });

            migrationBuilder.InsertData(
                table: "Financas",
                columns: new[] { "Id", "CompraId", "EmpresaId", "Lucro", "RegistroAtivo", "ValorCusto", "ValorVenda" },
                values: new object[,]
                {
                    { 1, 1, 1, 198m, true, 2m, 200m },
                    { 2, 2, 2, 300m, true, 3m, 303m }
                });

            migrationBuilder.InsertData(
                table: "ItensCompras",
                columns: new[] { "Id", "CompraId", "ProdutoId", "RegistroAtivo", "ValorItem" },
                values: new object[,]
                {
                    { 1, 1, 1, true, 2m },
                    { 2, 2, 2, true, 1123m }
                });

            migrationBuilder.InsertData(
                table: "ProdutosFavoritos",
                columns: new[] { "Id", "ClienteId", "ProdutoId", "RegistroAtivo" },
                values: new object[,]
                {
                    { 1, 1, 1, true },
                    { 2, 2, 2, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AvaliacoesEmpresas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AvaliacoesEmpresas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AvaliacoesProdutos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AvaliacoesProdutos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cartoes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cartoes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EnderecosClientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EnderecosClientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EnderecosEmpresas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EnderecosEmpresas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Estoques",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Estoques",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Financas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Financas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItensCompras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItensCompras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProdutosFavoritos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProdutosFavoritos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "RegistroAtivo",
                table: "Estoques");
        }
    }
}
