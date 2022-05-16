using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopApp.Migrations
{
    public partial class Produto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "PrecoVenda",
                table: "Produto",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.AlterColumn<float>(
                name: "PrecoCompra",
                table: "Produto",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "PrecoVenda",
                table: "Produto",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "PrecoCompra",
                table: "Produto",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "decimal(18,2)");
        }
    }
}
