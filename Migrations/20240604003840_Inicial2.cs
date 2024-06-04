using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ap1_P1_RalfyGenao.Migrations
{
    /// <inheritdoc />
    public partial class Inicial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ganancia",
                table: "Articulos",
                newName: "Ganacia");

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Articulos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "Ganacia",
                table: "Articulos",
                newName: "Ganancia");
        }
    }
}
