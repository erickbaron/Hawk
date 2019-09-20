using Microsoft.EntityFrameworkCore.Migrations;

namespace Hawk.Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Carrinhos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Quantidade",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Carrinhos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ItemCompraId", "Quantidade" },
                values: new object[] { 1, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Carrinhos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Quantidade",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Carrinhos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ItemCompraId", "Quantidade" },
                values: new object[] { 2, 0 });
        }
    }
}
