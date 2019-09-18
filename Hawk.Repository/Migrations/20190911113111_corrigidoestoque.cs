using Microsoft.EntityFrameworkCore.Migrations;

namespace Hawk.Repository.Migrations
{
    public partial class corrigidoestoque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Estoques",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistroAtivo",
                value: true);

            migrationBuilder.UpdateData(
                table: "Estoques",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistroAtivo",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Estoques",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistroAtivo",
                value: false);

            migrationBuilder.UpdateData(
                table: "Estoques",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistroAtivo",
                value: false);
        }
    }
}
