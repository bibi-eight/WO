using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WomenOpportunities.Migrations
{
    /// <inheritdoc />
    public partial class Contadores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantidadeDeFavoritos",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeDeOportunidades",
                table: "Instituicoes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantidadeDeFavoritos",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "QuantidadeDeOportunidades",
                table: "Instituicoes");
        }
    }
}
