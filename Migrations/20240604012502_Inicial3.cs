using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ap1_P1_RalfyGenao.Migrations
{
    /// <inheritdoc />
    public partial class Inicial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ganacia",
                table: "Articulos",
                newName: "Ganancia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ganancia",
                table: "Articulos",
                newName: "Ganacia");
        }
    }
}
