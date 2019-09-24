using Microsoft.EntityFrameworkCore.Migrations;

namespace Hawk.Repository.Migrations
{
    public partial class correçãoImagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Caminho",
                table: "Produtos",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagemURL",
                value: "imagem.jpg");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagemURL",
                value: "imagem.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Caminho",
                table: "Produtos");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagemURL",
                value: "download.jpg");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagemURL",
                value: "download.jpg");
        }
    }
}
