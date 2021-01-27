using Microsoft.EntityFrameworkCore.Migrations;

namespace CambioBank.Data.Migrations
{
    public partial class validarFila : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EstaNaFila",
                table: "Filas",
                nullable: false,
                defaultValue: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstaNaFila",
                table: "Filas");
        }
    }
}
